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
    public partial class DersForm : Form
    {
        SchoolDbContext context = new SchoolDbContext();
        public DersForm()
        {
            InitializeComponent();
            VerileriGetir();
        }
        private void VerileriGetir()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = context.Dersler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var ders = new Ders();
            ders.Ad= txtbxAd.Text;
            ders.Kod = txtbxKod.Text;
            ders.Kredi = Convert.ToInt32(txtbxKredi.Text);
            context.Add(ders);
            context.SaveChanges();

            VerileriGetir();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            var ders = (Ders)dataGridView1.SelectedRows[0].DataBoundItem;
            ders.Ad = txtbxAd.Text;
            ders.Kod = txtbxKod.Text;
            ders.Kredi = Convert.ToInt32(txtbxKredi.Text);
            context.Update(ders);
            context.SaveChanges();

            VerileriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var ders = (Ders)dataGridView1.SelectedRows[0].DataBoundItem;
            context.Remove(ders);
            context.SaveChanges();

            VerileriGetir();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ders = (Ders)dataGridView1.SelectedRows[0].DataBoundItem;
            txtbxAd.Text = ders.Ad;
            txtbxKod.Text = ders.Kod;
            txtbxKredi.Text = ders.Kredi.ToString();
        }

        private void dataGridView1_RowStateChanged(object? sender, DataGridViewRowStateChangedEventArgs e)
        {
            var ders = (Ders)dataGridView1.SelectedRows[0].DataBoundItem;
            txtbxAd.Text = ders.Ad;
            txtbxKod.Text = ders.Kod;
            txtbxKredi.Text = ders.Kredi.ToString();
        }
    }
}
