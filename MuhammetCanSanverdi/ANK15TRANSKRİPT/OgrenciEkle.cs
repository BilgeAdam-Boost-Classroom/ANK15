using ANK15TRANSKRİPT.Entity;
using System.Windows.Forms;
using System;
using ANK15TRANSKRİPT.Manager;

namespace ANK15TRANSKRİPT
{
    public partial class OgrenciEkle : Form
    {
        OgrenciManager ogrenciManager = new OgrenciManager();
        public OgrenciEkle()
        {
            InitializeComponent();
            BaseMethod.AddHeadDataGridView(typeof(Ogrenci), dataGridViewOgrenci);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var ogrenci = new Ogrenci()
            {
                Ad = txtbxAd.Text,
                Numara = txtbxNumara.Text,
                Soyad = txtbxSoyad.Text

            };

            Field.Ogrenciler.Add(ogrenci);
            dataGridViewOgrenci.Rows.Add(ogrenci.Ad, ogrenci.Soyad, ogrenci.Numara);

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            var selectFirstIndex = dataGridViewOgrenci.SelectedRows[0].Index;
            //var  ogrenci = s.Cast<Ogrenci>().ToList();
            //dataGridViewOgrenci.SelectedColumns.Clear();
            //var newOgrenci = new Ogrenci()
            //{
            //    Ad = txtbxAd.Text,
            //    Numara = txtbxNumara.Text,
            //    Soyad = txtbxSoyad.Text

            //};
            ogrenciManager.Update(Field.Ogrenciler[selectFirstIndex], dataGridViewOgrenci.SelectedRows[0].DataBoundItem as Ogrenci, Field.Ogrenciler);
            dataGridViewOgrenci.DataSource = null;
            dataGridViewOgrenci.DataSource = Field.Ogrenciler.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var selectFirstIndex = dataGridViewOgrenci.SelectedRows[0].Index;
            //var  ogrenci = s.Cast<Ogrenci>().ToList();
            //dataGridViewOgrenci.SelectedColumns.Clear();
           
            ogrenciManager.Delete(Field.Ogrenciler[selectFirstIndex], Field.Ogrenciler);
            dataGridViewOgrenci.Rows.RemoveAt(selectFirstIndex);
        }
    }
}
