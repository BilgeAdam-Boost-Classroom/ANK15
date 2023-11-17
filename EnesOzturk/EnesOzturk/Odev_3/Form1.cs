using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_3
{
    public partial class Form1 : Form
    {
        List<Calisan> calisanlar = new List<Calisan>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
            calisan.Ad=txtAd.Text;
            calisan.Soyad=txtSoyad.Text;
            calisan.Yas =int.Parse (txtYas.Text);
            calisan.Tc = long.Parse(txtTc.Text);

            calisanlar.Add(calisan);
            lbxCalisanlar.DataSource = null;
            lbxCalisanlar.DataSource= calisanlar;

            lbxCalisanlar.DisplayMember = "Tc";
            

            MessageBox.Show($"{calisan.Tc} listeye eklendi");
            


        }
    }
}
