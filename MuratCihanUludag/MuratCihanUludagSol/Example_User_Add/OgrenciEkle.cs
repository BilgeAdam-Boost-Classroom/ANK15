using Example_User_Add.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_User_Add
{

    public partial class OgrenciEkle : Form
    {
        UniversiteDbContext _db = new UniversiteDbContext();
        public OgrenciEkle()
        {
            InitializeComponent();
            DataAndComboLoad();

        }
        private void DataLoad()
        {
            dataGridV2.ColumnCount = 6;
            dataGridV2.Columns[0].Name = "Id";
            dataGridV2.Columns[1].Name = "Name";
            dataGridV2.Columns[2].Name = "SurName";
            dataGridV2.Columns[3].Name = "Number";
            dataGridV2.Columns[4].Name = "DanismanId";
            dataGridV2.Columns[5].Name = "DiplomaId";
            dataGridV2.Rows.Clear();
            foreach (var item in _db.Ogrencilers)
            {
                dataGridV2.Rows.Add(item.Id, item.Ad, item.Soyad,
                            item.Numara, item.DanismanId, item.DiplomaId);
            }
            dataGridV3.Rows.Clear();
            dataGridV3.ColumnCount = 3;
            dataGridV3.Columns[0].Name = "Id";
            dataGridV3.Columns[1].Name = "No";
            dataGridV3.Columns[2].Name = "Tarih";
            foreach (var item in _db.Diplomalars)
            {
                dataGridV3.Rows.Add(item.Id, item.No, item.Tarih);
            }

            dataGridV4.Rows.Clear();
            dataGridV4.ColumnCount = 4;
            dataGridV4.Columns[0].Name = "Id";
            dataGridV4.Columns[1].Name = "Ad";
            dataGridV4.Columns[2].Name = "Kod";
            dataGridV4.Columns[3].Name = "Kredi";

            foreach (var item in _db.Derslers)
            {
                dataGridV4.Rows.Add(item.Id, item.Ad, item.Kod, item.Kredi);
            }
        }
        private void LoadCombo()
        {
            comboBoxOgr.DataSource = _db.Ogrencilers.ToList();
            comboBoxOgr.DisplayMember = "AdSoyad";
            comboBoxOgr.ValueMember = "Id";

            comboBoxDnm.DataSource = _db.Danismanlars.ToList();
            comboBoxDnm.DisplayMember = "AdSoyad";
            comboBoxDnm.ValueMember = "Id";

            var atanamamisDiplama = _db.Diplomalars
                .Where(x => x.Ogrenciler == null)
                .ToList();
            if (atanamamisDiplama.Count != 0)
            {
                comboBoxDiploama.DataSource = atanamamisDiplama;
                comboBoxDiploama.DisplayMember = "No";
                comboBoxDiploama.ValueMember = "Id";
                buttonEkle.Enabled = true;
            }
            else
            {
                comboBoxDiploama.DataSource = null;
                comboBoxDiploama.Text = "";
                buttonEkle.Enabled = false;
            }
        }
        private object IdFounder(DataGridView dataGrid)
        {
            int row = dataGrid.SelectedCells[0].RowIndex;
            object selectId = dataGrid.Rows[row].Cells[0].Value;
            return selectId;

        }
        private void DataAndComboLoad()
        {
            DataLoad();
            LoadCombo();
        }
        #region AddMethot
        private void AddOgrenci()
        {
            Ogrenciler newOgrenci = new Ogrenciler();

            newOgrenci.Ad = textBox1.Text;
            newOgrenci.Soyad = textBox2.Text;
            newOgrenci.Numara = textBox3.Text;
            newOgrenci.DiplomaId = (int)comboBoxDiploama.SelectedValue;

            _db.Ogrencilers.Add(newOgrenci);
        }
        private void AddDiploma()
        {
            Diplomalar newDiploama = new Diplomalar();
            newDiploama.No = Convert.ToInt32(textBoxNo.Text);
            newDiploama.Tarih = DateOnly.Parse(textBoxDate.Text);

            _db.Diplomalars.Add(newDiploama);
        }
        private void AddDers()
        {
            Dersler newDersler = new Dersler();
            newDersler.Ad = textBoxDersAd.Text;
            newDersler.Kod = textBoxDersKod.Text;
            newDersler.Kredi = Convert.ToInt32(textBoxDersKredi.Text);

            _db.Derslers.Add(newDersler);
        }
        #endregion
        #region UpdateMethots
        private void UpdateOgrenci()
        {
            int id = (int)IdFounder(dataGridV2);
            var updateOgrenci = _db.Ogrencilers.FirstOrDefault(d => d.Id == id);

            updateOgrenci.Ad = textBox1.Text;
            updateOgrenci.Soyad = textBox2.Text;
            updateOgrenci.Numara = textBox3.Text;
        }

        private void UpdateDiploma()
        {
            int id = (int)IdFounder(dataGridV3);
            var updateDiploma = _db.Diplomalars.FirstOrDefault(d => d.Id == id);

            updateDiploma.No = Convert.ToInt32(textBoxNo.Text);
            updateDiploma.Tarih = DateOnly.Parse(textBoxDate.Text);
        }
        private void UpdateDers()
        {
            int id = (int)IdFounder(dataGridV4);
            var updateDers = _db.Derslers.FirstOrDefault(d => d.Id == id);

            updateDers.Ad = textBoxDersAd.Text;
            updateDers.Kod = textBoxDersKod.Text;
            updateDers.Kredi = Convert.ToInt32(textBoxDersKredi.Text);

        }
        #endregion
        #region DeleteMethots
        private void DeleteOgrenci()
        {
            int id = (int)IdFounder(dataGridV2);
            var dalateOgrenci = _db.Ogrencilers.FirstOrDefault(d => d.Id == id);

            _db.Ogrencilers.Remove(dalateOgrenci);
        }
        private void DeleteDiploma()
        {
            int id = (int)IdFounder(dataGridV3);
            var deleteDiploama = _db.Diplomalars.FirstOrDefault(d => d.Id == id);

            _db.Diplomalars.Remove(deleteDiploama);
        }
        private void DeleteDers()
        {
            int id = (int)IdFounder(dataGridV4);
            var deleteDers = _db.Derslers.FirstOrDefault(d => d.Id == id);

            _db.Derslers.Remove(deleteDers);
        }
        #endregion
        #region ButtonsEvents
        private void Add(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Tag == "OgrenciEkle")
            {
                AddOgrenci();
            }
            else if (button.Tag == "DiplomaEkle")
            {
                AddDiploma();
            }
            else if (button.Tag == "DersEkle")
            {
                AddDers();
            }
            _db.SaveChanges();
            DataAndComboLoad();
        }
        private void Update(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Tag == "OgrenciGuncelle")
            {
                UpdateOgrenci();

            }
            else if (button.Tag == "DiplomaGuncelle")
            {
                UpdateDiploma();
            }
            else if (button.Tag == "DersGuncelle")
            {
                UpdateDers();
            }
            _db.SaveChanges();
            DataAndComboLoad();
        }
        private void Delete(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Tag == "OgrenciSil")
            {
                DeleteOgrenci();

            }
            else if (button.Tag == "DiplomaSil")
            {
                DeleteDiploma();
            }
            else if (button.Tag == "DersSil")
            {
                DeleteDers();
            }
            _db.SaveChanges();
            DataAndComboLoad();
        }

        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            int ogrId = (int)comboBoxOgr.SelectedValue;
            int dnmId = (int)comboBoxDnm.SelectedValue;

            var updateOgr = _db.Ogrencilers.FirstOrDefault(o => o.Id == ogrId);
            var getDnm = _db.Danismanlars.FirstOrDefault(d => d.Id == dnmId);

            updateOgr.DanismanId = dnmId;
            dnmGet.Text = $"{getDnm.Ad}  {getDnm.Soyad}";

            _db.SaveChanges();
            DataLoad();

        }

    }
}
