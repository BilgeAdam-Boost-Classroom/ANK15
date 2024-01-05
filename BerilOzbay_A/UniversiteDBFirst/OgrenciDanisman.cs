using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteDBFirst.Models;

namespace UniversiteDBFirst
{
    public partial class OgrenciDanisman : Form
    {
        public OgrenciDanisman()
        {
            UniversiteDbContext _db = new UniversiteDbContext();
            InitializeComponent();
            cbxOgrenci.DataSource = _db.Ogrenciler.ToList();
            cbxDanisman.DataSource = _db.Danismanlar.ToList();
        }

        private void btnDanismanAta_Click(object sender, EventArgs e)
        {
            UniversiteDbContext _db = new UniversiteDbContext();
            Ogrenciler secilenOgrenci = (Ogrenciler)cbxOgrenci.SelectedItem;

            Danismanlar secilenDanisman = (Danismanlar)cbxDanisman.SelectedItem;
            var ogr = _db.Ogrenciler.FirstOrDefault(x => x.Id == secilenOgrenci.Id);
            ogr.DanismanId = secilenDanisman.Id;
            _db.SaveChanges();
        }

        private void cbxOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            UniversiteDbContext _db = new UniversiteDbContext();
            Ogrenciler secilenOgrenci = (Ogrenciler)cbxOgrenci.SelectedItem;
            var ogrenciDanisman = _db.Danismanlar.FirstOrDefault(d => d.Id == secilenOgrenci.DanismanId);
            if (ogrenciDanisman != null)
            {
                lblDanisman.Text = ogrenciDanisman.Ad + " " + ogrenciDanisman.Soyad;
            }
            else
            {
                lblDanisman.Text = "Ogrenciye henuz danisman atanmamistir.";
            }
        }
    }
}
