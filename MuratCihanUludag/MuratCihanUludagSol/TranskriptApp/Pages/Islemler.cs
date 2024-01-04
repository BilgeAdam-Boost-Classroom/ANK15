using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranskriptApp.Models.Abstract.Managed;
using TranskriptApp.Models.Classes;
using TranskriptApp.Models.Classes.Managed;
using TranskriptApp.Models.CustomDbList;

namespace TranskriptApp.Pages
{
    public partial class Islemler : Form
    {
        string listName;
        string ogrenci = "Ogrenci";
        string ders = "Ders";
        string donem = "Donem";
        public Islemler()
        {
            InitializeComponent();

            radioButtonOgr.CheckedChanged += ChengeFormList;
            radioButtonDers.CheckedChanged += ChengeFormList;
            radioButtonDonem.CheckedChanged += ChengeFormList;

            radioButtonOgr.Checked = true;
        }
        #region RadiButtonEvents
        private void ChengeFormList(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                SingleForm(radioButton);
            }
        }
        private void SingleForm(RadioButton radioButton)
        {
            switch (radioButton.Name)
            {
                case "radioButtonOgr":
                    SetLabels(this.ogrenci, "Ogrenci Ismi", "Ogrenci Soyismi", "Ogrenci Numarasi");
                    break;
                case "radioButtonDers":
                    SetLabels(this.ders, "Ders Ismi","Ders Kredisi");
                    break;
                case "radioButtonDonem":
                    SetLabels(this.donem, "Donem Ismi");
                    break;
            }
            GenerateTable();
        }
        private void SetLabels(string listName, string label1Text, string label2Text = "", string label3Text = "")
        {
            this.listName = listName;
            label1.Text = label1Text;
            label2.Text = label2Text;
            label3.Text = label3Text;

            label2.Visible = !string.IsNullOrEmpty(label2Text);
            label3.Visible = !string.IsNullOrEmpty(label3Text);

            textBox2.Visible = !string.IsNullOrEmpty(label2Text);
            textBox3.Visible = !string.IsNullOrEmpty(label3Text);
        }
        #endregion
        #region DataGridTabloGenerator
        private void GenerateTable()
        {
            dataGridView1.Rows.Clear();
            if (this.listName == this.ogrenci)
            {
                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].Name = "Id";
                dataGridView1.Columns[1].Name = "Ogrenci adi";
                dataGridView1.Columns[2].Name = "Ogrenci Soyadi";
                dataGridView1.Columns[3].Name = "Ogrenci Numarasi";
                dataGridView1.Columns[0].Visible = false;
                foreach (Ogrenci ogrenci in OgrenciList.ogrenciLists)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, ogrenci.Id, ogrenci.Name, ogrenci.SurName, ogrenci.Number);
                    dataGridView1.Rows.Add(row);
                }
            }
            else if (this.listName == this.ders)
            {
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "Id";
                dataGridView1.Columns[1].Name = "Ders Adi";
                dataGridView1.Columns[2].Name = "Ders Kredisi";
                dataGridView1.Columns[0].Visible = false;

                foreach (Ders ders in DersList.ders)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, ders.Id, ders.Name,ders.Kredi);
                    dataGridView1.Rows.Add(row);
                }
            }
            else
            {
                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Id";
                dataGridView1.Columns[1].Name = "Donem Adi";
                dataGridView1.Columns[0].Visible = false;

                foreach (Donem donem in DonemList.donemList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1, donem.Id, donem.Name);
                    dataGridView1.Rows.Add(row);
                }

            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = 150;
            }
        }
        #endregion
        #region AddEvent
        private void button1_Click(object sender, EventArgs e)
        {
            if (listName == this.ogrenci)
            {
                Ogrenci ogrenci = new Ogrenci();
                BaseManager<Ogrenci> menager = new OgrenciManager(OgrenciList.ogrenciLists);

                ogrenci.Name = textBox1.Text;
                ogrenci.SurName = textBox2.Text;
                ogrenci.Number = textBox3.Text;
                dataGridView1.Rows.Add(ogrenci.Id, ogrenci.Name, ogrenci.SurName, ogrenci.Number);
                menager.Add(ogrenci);


            }
            else if (listName == this.ders)
            {
                Ders ders = new Ders();
                BaseManager<Ders> manager = new DersManager(DersList.ders);
                
                ders.Name = textBox1.Text;
                ders.Kredi = textBox2.Text;

                if (manager.GetAll().Any(d => d.Name == ders.Name))
                {
                    MessageBox.Show("Ders Bulunmaktadir");
                }
                else
                {
                    dataGridView1.Rows.Add(ders.Id, ders.Name, ders.Kredi);
                    manager.Add(ders);
                }
            }
            else
            {
                Donem donem = new Donem();
                BaseManager<Donem> manager = new DonemManger(DonemList.donemList);

                donem.Name = textBox1.Text;
                dataGridView1.Rows.Add(donem.Id, donem.Name);
                manager.Add(donem);
            }
        }

        #endregion
        #region IdFound
        private int IdFound()
        {
            try
            {

                int index = dataGridView1.SelectedRows[0].Index;
                object idCells = dataGridView1.Rows[index].Cells["Id"].Value;
                return (int)idCells;
            }
            catch
            {
                MessageBox.Show("Tum Stunu Seciniz");
            }
            return -1;
        }

        #endregion
        #region DeleteEvent
        private void button2_Click(object sender, EventArgs e)
        {

            int id = IdFound();
            if (id != 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                if (this.listName == this.ogrenci)
                {
                    BaseManager<Ogrenci> menager = new OgrenciManager(OgrenciList.ogrenciLists);
                    var deleteOgrenci = menager.Get(id);
                    menager.Remove(deleteOgrenci);
                }
                else if (this.listName == this.ders)
                {
                    BaseManager<Ders> meneger = new DersManager(DersList.ders);
                    var deleteDers = meneger.Get(id);
                    meneger.Remove(deleteDers);
                }
                else
                {
                    BaseManager<Donem> meneger = new DonemManger(DonemList.donemList);
                    var deleteDers = meneger.Get(id);
                    meneger.Remove(deleteDers);
                }

            }
        }
        #endregion
        #region UpdateEvent
        private void button3_Click(object sender, EventArgs e)
        {
            int id = IdFound();
            if (id != -1)
            {
                if (this.listName == this.ogrenci)
                {
                    BaseManager<Ogrenci> menager = new OgrenciManager(OgrenciList.ogrenciLists);
                    var ogrenciUpdate = menager.Get(id);
                    ogrenciUpdate.Name = textBox1.Text;
                    ogrenciUpdate.SurName = textBox2.Text;
                    ogrenciUpdate.Number = textBox3.Text;
                    menager.Put(id, ogrenciUpdate);

                }
                else if (this.listName == this.ders)
                {
                    BaseManager<Ders> meneger = new DersManager(DersList.ders);
                    var dersUpdate = meneger.Get(id);
                    dersUpdate.Name = textBox1.Text;
                    dersUpdate.Kredi = textBox2.Text;
                    meneger.Put(id, dersUpdate);
                }
                else
                {
                    BaseManager<Donem> meneger = new DonemManger(DonemList.donemList);
                    var updateDonem = meneger.Get(id);
                    updateDonem.Name = textBox1.Text;
                    meneger.Put(id, updateDonem);
                }
                GenerateTable();
            }

        }
        #endregion
    }
}
