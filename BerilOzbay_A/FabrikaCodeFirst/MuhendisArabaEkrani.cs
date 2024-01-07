using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabrikaCodeFirst
{
    public partial class MuhendisArabaEkrani : Form
    {
        FabrikaDbContext _db = new FabrikaDbContext();
        MuhendisAraba secilenMuhendisAraba;
        public MuhendisArabaEkrani()
        {
            InitializeComponent();
            cbxAraba.DataSource = _db.Arabalar.ToList();
            cbxMuhendis.DataSource = _db.Muhendisler.ToList();
            MuhendisArabalariGoster();
        }
        private void MuhendisArabalariGoster()
        {
            dgvMuhendisAraba.DataSource = null;
            dgvMuhendisAraba.DataSource = _db.MuhendisAraba.ToList();
            if (dgvMuhendisAraba.Columns[0].Visible)
                dgvMuhendisAraba.Columns[0].Visible = false;
        }
        private void dgvMuhendisAraba_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenMuhendisAraba = (MuhendisAraba)dgvMuhendisAraba.SelectedRows[0].DataBoundItem;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                MuhendisAraba muhendisAraba = new MuhendisAraba();
                muhendisAraba.ArabaId = ((Araba)cbxAraba.SelectedItem).Id;
                muhendisAraba.MuhendisId = ((Muhendis)cbxMuhendis.SelectedItem).Id;

                _db.MuhendisAraba.Add(muhendisAraba);
                _db.SaveChanges();
                MuhendisArabalariGoster();
                MessageBox.Show("Başarı ile eklendi.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenMuhendisAraba != null)
                {
                    _db.MuhendisAraba.Remove(secilenMuhendisAraba);
                    _db.SaveChanges();
                    MuhendisArabalariGoster();
                    secilenMuhendisAraba = null;
                    MessageBox.Show("Başari ile silinmiştir");
                }

                else
                {
                    MessageBox.Show("Lutfen Muhendis-Araba seciniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);

            }
        }
    }
}
