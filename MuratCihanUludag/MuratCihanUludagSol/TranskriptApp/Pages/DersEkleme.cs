using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranskriptApp.Models.Classes;
using TranskriptApp.Models.Classes.Managed;
using TranskriptApp.Models.CustomDbList;
using TranskriptApp.Models.Enum;

namespace TranskriptApp.Pages
{
    public partial class DersEkleme : Form
    {
        public DersEkleme()
        {
            InitializeComponent();

            comboBoxOgr.DisplayMember = "Name";
            comboBoxOgr.ValueMember = "Id";
            comboBoxOgr.DataSource = OgrenciList.ogrenciLists;

            comboBoxDers.DisplayMember = "Name";
            comboBoxDers.ValueMember = "Id";
            comboBoxDers.DataSource = DersList.ders;

            comboBoxDonem.DisplayMember = "Name";
            comboBoxDonem.ValueMember = "Id";
            comboBoxDonem.DataSource = DonemList.donemList;

            comboBoxHarfNot.DataSource = Enum.GetValues(typeof(HarfNot));

            GenerateTable();


        }

        private void GenerateTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Ogrenci adi";
            dataGridView1.Columns[2].Name = "Ogrenci Soyadi";
            dataGridView1.Columns[3].Name = "Donem";
            dataGridView1.Columns[4].Name = "Ders";
            dataGridView1.Columns[5].Name = "Notu";

            dataGridView1.Columns[0].Visible = false;

            foreach (var ogrenciDers in OgrenciDersList.OgrenciDersLists)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, ogrenciDers.Id, ogrenciDers.Ogrenci.Name,
                    ogrenciDers.Ogrenci.SurName, ogrenciDers.Donem.Name, ogrenciDers.Ders.Name,
                    ogrenciDers.HarfNot);

                dataGridView1.Rows.Add(row);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedOgrenci = (Ogrenci)comboBoxOgr.SelectedItem;
            var selecetDonem = (Donem)comboBoxDonem.SelectedItem;
            var selecetDers = (Ders)comboBoxDers.SelectedItem;
            var selecetHarfNot = (HarfNot)comboBoxHarfNot.SelectedItem;

            OgrenciDers ogrenciDers = new OgrenciDers();

            ogrenciDers.Ogrenci = selectedOgrenci;
            ogrenciDers.Ders = selecetDers;
            ogrenciDers.Donem = selecetDonem;
            ogrenciDers.HarfNot = selecetHarfNot;

            OgrenciDersList.OgrenciDersLists.Add(ogrenciDers);


            dataGridView1.Rows.Add(selectedOgrenci.Id, selectedOgrenci.Name, selectedOgrenci
                                    .SurName, selecetDonem.Name, selecetDers.Name, selecetHarfNot);
        }

        private int IdFound()
        {
            try
            {

                int index = dataGridView1.SelectedRows[0].Index;
                object idCelss = dataGridView1.Rows[index].Cells["Id"].Value;
                return (int)idCelss;
            }
            catch
            {
                return -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = IdFound();
            if (id != -1)
            {
                BaseManager<OgrenciDers> manager = new OgrenciDersManaged(OgrenciDersList.OgrenciDersLists);
                var deleteOgrenciDers = manager.Get(id);
                manager.Remove(deleteOgrenciDers);
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transkript transkript = new Transkript();
            transkript.Show();
        }
    }
}
