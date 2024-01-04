using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranskriptApp.Models.Abstract;
using TranskriptApp.Models.Classes;
using TranskriptApp.Models.CustomDbList;
using TranskriptApp.Models.Enum;

namespace TranskriptApp.Pages
{
    public partial class Transkript : Form
    {
        public Transkript()
        {
            InitializeComponent();

            comboBoxOgr.DisplayMember = "Name";
            comboBoxOgr.ValueMember = "Id";
            comboBoxOgr.DataSource = OgrenciList.ogrenciLists;

            comboBoxDonem.DisplayMember = "Name";
            comboBoxDonem.ValueMember = "Id";
            comboBoxDonem.DataSource = DonemList.donemList;


        }

        private void GenerateTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Ders Adi";
            dataGridView1.Columns[2].Name = "Ders Kredisi";
            dataGridView1.Columns[3].Name = "Donem";
            dataGridView1.Columns[4].Name = "Notu";

            dataGridView1.Columns[0].Visible = false;

            var newOgrenciList = OgrenciDersList.OgrenciDersLists.Where(c => c.Ogrenci.Name == comboBoxOgr.Text &&
            c.Donem.Name == comboBoxDonem.Text).ToList();

            var newOgrenciListGenel = OgrenciDersList.OgrenciDersLists.Where(c => c.Ogrenci.Name == comboBoxOgr.Text).ToList();

            int Tkredi = 0;
            int GTkredi = 0;
            double donemOrt = 0;
            double genelOrt = 0;
            foreach (var ogrenciDers in newOgrenciList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, ogrenciDers.Id, ogrenciDers.Ders.Name,
                    ogrenciDers.Ders.Kredi, ogrenciDers.Donem.Name, ogrenciDers.HarfNot);

                Tkredi += Convert.ToInt32(ogrenciDers.Ders.Kredi);
                dataGridView1.Rows.Add(row);
                donemOrt += (DersHarfKatSayi(ogrenciDers.HarfNot) * Convert.ToInt32(ogrenciDers.Ders.Kredi));
            }

            foreach (var item in newOgrenciListGenel)
            {
                GTkredi += Convert.ToInt32(item.Ders.Kredi);
                genelOrt += (DersHarfKatSayi(item.HarfNot) * Convert.ToInt32(item.Ders.Kredi));
            }

            toplamKredi.Text = Tkredi.ToString();
            DonemOrtalama.Text = (donemOrt / Tkredi).ToString();
            GenelOrt.Text = ((genelOrt / GTkredi)).ToString("0.000");
        }
        private double DersHarfKatSayi(HarfNot harf)
        {
            switch (harf)
            {
                case HarfNot.AA:
                    return 4;
                case HarfNot.BA:
                    return 3.5;
                case HarfNot.BB:
                    return 3;
                case HarfNot.CB:
                    return 2.5;
                case HarfNot.CC:
                    return 2;
                case HarfNot.DC:
                    return 1.5;
                case HarfNot.DD:
                    return 1;
                case HarfNot.FF:
                    return 0;
                default:
                    return 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GenerateTable();
        }
    }
}
