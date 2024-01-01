using Microsoft.IdentityModel.Tokens;
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
    public partial class OgrenciyeDanisman : Form
    {
        UniversiteDbContext _db = new UniversiteDbContext();

        public OgrenciyeDanisman()
        {
            InitializeComponent();
            Goster();
        }
        private void Goster()
        {
            comboBox1.DataSource = _db.Ogrencilers.ToList();
            comboBox2.DataSource = _db.Danismanlars.ToList();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciler secilenOgrenci = (Ogrenciler)comboBox1.SelectedItem;
            Danismanlar secilenDanisman = (Danismanlar)comboBox2.SelectedItem;

            if (secilenOgrenci != null && secilenDanisman != null)
            {
                secilenOgrenci.DanismanId = secilenDanisman.Id;

                _db.SaveChanges();
                MessageBox.Show("başarıyla güncellenmiştir");
                label1.Text = "Danışmanı: " + secilenDanisman.ToString();

            }
            else
                MessageBox.Show("Ogrenci ve Danışman seçmediniz!");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ogrenciler secilenOgrenci = (Ogrenciler)comboBox1.SelectedItem;
            if (secilenOgrenci == null)
                return;
            if (!string.IsNullOrEmpty(secilenOgrenci.DanismanId.ToString()))
            {
                Danismanlar danisman =_db.Danismanlars.First(d => d.Id == secilenOgrenci.DanismanId);
                label1.Text = "Danışmanı: " + danisman.ToString();          
            }
            else
            {
                label1.Text = "Danışmanı henüz atanmamıştır!";
            }
        }
    }
}
