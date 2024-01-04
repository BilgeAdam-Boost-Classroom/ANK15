using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteDBUygulama.Models;

namespace UniversiteDBUygulama
{
    public partial class OgrenciForm : Form
    {
        UniversiteDbContext _db = new UniversiteDbContext();
        Ogrenciler ogrenci = new Ogrenciler();
        Danismanlar danisman = new Danismanlar();
        public OgrenciForm()
        {
            InitializeComponent();
            cbxOgrenci.DataSource = _db.Ogrencilers.ToList();
            cbxDanisman.DataSource = _db.Danismanlars.ToList();
        }

        private void cbxOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            ogrenci = ((Ogrenciler)(cbxOgrenci.SelectedItem));
            var ogrenciDanisman = _db.Danismanlars.FirstOrDefault(d => d.Id == ogrenci.DanismanId);
            if (ogrenciDanisman != null)
                lblDanisman.Text = ogrenciDanisman.Ad + " " + ogrenciDanisman.Soyad;
            else
                lblDanisman.Text = "Öğrenciye henüz danışman atamamıştır.";
        }

        private void cbxDanisman_SelectedIndexChanged(object sender, EventArgs e)
        {
            danisman = ((Danismanlar)(cbxDanisman.SelectedItem));

        }

        private void btnDanismanAta_Click(object sender, EventArgs e)
        {
            ogrenci.DanismanId = danisman.Id;
            _db.SaveChanges();
        }
    }
}
