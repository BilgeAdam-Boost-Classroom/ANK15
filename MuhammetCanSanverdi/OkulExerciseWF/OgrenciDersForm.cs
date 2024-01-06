using OkulExerciseWF.Entity;
using SchoolExercise;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulExerciseWF
{
    public partial class OgrenciDersForm : Form
    {
        SchoolDbContext _context = new SchoolDbContext();
        int _not;
        OgrenciDers _ogrenciDers;

        public OgrenciDersForm()
        {
            InitializeComponent();
            cbxDers.DataSource = _context.Dersler.ToList();
            cbxOgrenci.DataSource = _context.Ogrenciler.ToList();
            dataGridView1.DataSource = _context.OgrenciDersler.ToList();
        }

        private void OgrenciDersForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (NotValidator())
            {
                var dersId = (cbxDers.SelectedItem as Ders).Id;
                var ogrenciId = (cbxOgrenci.SelectedItem as Ogrenci).Id;

                var OgrenciDers = new OgrenciDers() { DersId = dersId, OgrenciId = ogrenciId, Not = _not };
                _context.OgrenciDersler.Add(OgrenciDers);
                _context.SaveChanges();
                MessageBox.Show("Öğrenci ders bilgileri eklendi");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var deletedOgrenciDers = dataGridView1.SelectedRows[0].DataBoundItem as OgrenciDers;
            _context.OgrenciDersler.Remove(deletedOgrenciDers);
            _context.SaveChanges();
            MessageBox.Show("Öğrenci ders bilgileri silindi");
        }

        private bool NotValidator()
        {
            _not = 0;
            try
            {
                _not = int.Parse(txtNot.Text);
                return true;
            }
            catch (Exception e)
            {

                MessageBox.Show("Not alanına 0-100 aralığında bir değer giriniz.");
                return false;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _ogrenciDers = dataGridView1.SelectedRows[0].DataBoundItem as OgrenciDers;
            var dersIndex = cbxDers.Items.IndexOf(_ogrenciDers);
            cbxDers.SelectedIndex = dersIndex;

            var ogrenciIndex = cbxDers.Items.IndexOf(_ogrenciDers);
            cbxDers.SelectedIndex = ogrenciIndex;

            txtNot.Text = _ogrenciDers.Not.ToString();

        }
    }
}
