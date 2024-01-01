using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteEF1.Models;

namespace UniversiteEF1
{
    public partial class Diploma : Form
    {
        UniversiteDbContext _db = new UniversiteDbContext();
        Diplomalar secilenDiploma;
        public Diploma()
        {
            InitializeComponent();
            Goster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            string no = txtNo.Text;
            DateOnly selectedDate = DateOnly.FromDateTime(dateTimePicker1.Value);

            Diplomalar diploma = new Diplomalar();
            diploma.No = Convert.ToInt32(no);
            diploma.Tarih = selectedDate;
            _db.Diplomalars.Add(diploma);
            _db.SaveChanges();
            Goster();
            MessageBox.Show("veritabanına eklenmiştir");
        }
        private void Goster()
        {
            dGWDiploma.DataSource = null;
            dGWDiploma.DataSource = _db.Diplomalars.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenDiploma != null)
            {
                secilenDiploma.No = Convert.ToInt32(txtNo.Text);
                secilenDiploma.Tarih = DateOnly.FromDateTime(dateTimePicker1.Value);

                _db.SaveChanges();
                MessageBox.Show("başarıyla güncellenmiştir");
                secilenDiploma = null;
                lblsecilenDiploma.Text = "Seçilen Diploma:";
                Goster();

            }
            else
                MessageBox.Show("diploma seç");
        }

        private void dGWDiploma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDiploma = (Diplomalar)dGWDiploma.SelectedRows[0].DataBoundItem; //satırdaki tıklanan
            txtNo.Text = secilenDiploma.No.ToString();
            dateTimePicker1.Value = secilenDiploma.Tarih.ToDateTime(TimeOnly.Parse("00:00 PM"));

            lblsecilenDiploma.Text = "Seçilen Diploma:" + secilenDiploma.No + " " + secilenDiploma.Tarih;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenDiploma != null)
            {
                _db.Diplomalars.Remove(secilenDiploma);


                _db.SaveChanges();
                MessageBox.Show("başarıyla silinmiştir");
                secilenDiploma = null;
                lblsecilenDiploma.Text = "Seçilen Diploma:";
                Goster();

            }
            else
                MessageBox.Show("diploma seç");
        }
    }
}
