using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabrikaCodeFirst
{
    public partial class ArabaEkrani : Form
    {
        FabrikaDbContext _db = new FabrikaDbContext();
        Araba secilenAraba;
        public ArabaEkrani()
        {
            InitializeComponent();
            ArabalariGoster();
            cbxKisi.DataSource = _db.Kisiler.ToList();
            cbxPlaka.DataSource = _db.Plakalar.ToList();
            cbxPlaka.SelectedItem = null;
            cbxKisi.SelectedItem = null;
        }
        private void ArabalariGoster()
        {
            dgvArabalar.DataSource = null;
            dgvArabalar.DataSource = _db.Arabalar.ToList();
            if (dgvArabalar.Columns[0].Visible)
                dgvArabalar.Columns[0].Visible = false;
        }
        private void dgvArabalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenAraba = (Araba)dgvArabalar.SelectedRows[0].DataBoundItem;
            txtModel.Text = secilenAraba.Model;
            txtYil.Text = secilenAraba.Yıl;
            cbxKisi.SelectedItem = secilenAraba.Kisi;
            cbxPlaka.SelectedItem = secilenAraba.Plaka;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Araba araba = new Araba();
                araba.Model = txtModel.Text;
                araba.Yıl = txtYil.Text;
                araba.PlakaId = ((Plaka)cbxPlaka.SelectedItem).Id;
                araba.KisiId = ((Kisi)cbxKisi.SelectedItem).Id;
                _db.Arabalar.Add(araba);
                _db.SaveChanges();
                ArabalariGoster();
                MessageBox.Show("Basari ile eklendi.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenAraba != null)
                {
                    secilenAraba.Model = txtModel.Text;
                    secilenAraba.Yıl = txtYil.Text;
                    secilenAraba.PlakaId = ((Plaka)cbxPlaka.SelectedItem).Id;
                    secilenAraba.KisiId = ((Kisi)cbxKisi.SelectedValue).Id;


                    _db.SaveChanges();
                    ArabalariGoster();
                    MessageBox.Show("Başari ile güncellendi.");
                }

                else
                {
                    MessageBox.Show("Lutfen araba seçiniz");
                }
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
                if (secilenAraba != null)
                {
                    _db.Arabalar.Remove(secilenAraba);
                    _db.SaveChanges();
                    txtModel.Text = null;
                    txtYil.Text = null;
                    cbxKisi.SelectedItem = null;
                    cbxPlaka.SelectedItem = null;

                    ArabalariGoster();

                    MessageBox.Show("Başari ile silinmiştir");

                }

                else
                {
                    MessageBox.Show("Lutfen araba seciniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);

            }
        }
    }
}
