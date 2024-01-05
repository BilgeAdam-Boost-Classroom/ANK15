using Ex03_01_2024.Context;
using Ex03_01_2024.Models;
using System.Windows.Forms;

namespace Ex03_01_2024
{
    public partial class Form1 : Form
    {
        OkulDbContext _db = new OkulDbContext();
        Diploma secilenDiploma;
        Danisman secilenDanisman;
        public Form1()
        {
            InitializeComponent();
            //Acilista da giri'de gosterilsin
            DiplomalariGoster();
            DanismanGuncelle();
            OgrenciGoster();
            DersGoster();
            DersComboGoster();
            OgrenciComboGoster();
        }
        private void DiplomalariGoster()
        {
            dataGridDiploamalar.DataSource = null;
            dataGridDiploamalar.DataSource = _db.Diplomas.ToList();

            dataGridDiploamalar.Columns["Id"].Visible = false; // Id yi Goster
            DiplomaCombo();
        }
        private void DanismanGuncelle()
        {
            dataGridDanisman.DataSource = null;
            dataGridDanisman.DataSource = _db.Danismanlar.ToList();

            dataGridDanisman.Columns[0].Visible = false; // Id yi Goster
            dataGridDanisman.Columns[3].Visible = false;

            DanismanCombo();
        }
        private void OgrenciGoster()
        {
            dataGridOgrenci.DataSource = null;
            dataGridOgrenci.DataSource = _db.Orenciler.ToList();
            dataGridOgrenci.Columns["Id"].Visible = false; // Id yi Goster

            dataGridOgrenci.Columns["Diploma"].Visible = false;
            dataGridOgrenci.Columns["Danisman"].Visible = false;
            dataGridOgrenci.Columns["OgrenciDersler"].Visible = false;

        }
        private void DersGoster()
        {
            dataGridDers.DataSource = null;
            dataGridDers.DataSource = _db.Dersler.ToList();
            dataGridDers.Columns["Id"].Visible = false;
            dataGridDers.Columns[4].Visible = false;
            dataGridDers.Columns[5].Visible = false;
        }
        private void DanismanCombo()
        {
            cbDanismanOgrenci.DataSource = _db.Danismanlar.ToList();
            cbDanismanOgrenci.DisplayMember = "NameSurname";
            cbDanismanOgrenci.ValueMember = "ID";
        }

        private void DiplomaCombo()
        {
            cbOgrenciDiplama.DataSource = _db.Diplomas.ToList();
            cbOgrenciDiplama.DisplayMember = "No";
            cbOgrenciDiplama.ValueMember = "ID";
        }
        private int IdFounder(DataGridView dataGrid)
        {
            int index = dataGrid.SelectedRows[0].Index;
            object idCelss = dataGrid.Rows[index].Cells[0].Value;
            return (int)idCelss;


        }

        private void btnAdd(object sender, EventArgs e)
        {
            var buttonTag = (Button)sender;
            switch (buttonTag.Tag)
            {
                case "danismanEkle":
                    Danisman danisman = new Danisman();
                    danisman.Name = txtDanismanAd.Text;
                    danisman.Surname = txtDanismanSoyad.Text;
                    _db.Danismanlar.Add(danisman);
                    _db.SaveChanges();
                    DanismanGuncelle();
                    break;
                case "ogrenciEkle":
                    Ogrenci newOgrenci = new Ogrenci();
                    newOgrenci.Name = txtOgrenciAd.Text;
                    newOgrenci.Surname = txtOgrenciSoyad.Text;
                    newOgrenci.BirthDay = dtOgrenciPiker.Value;
                    newOgrenci.DanismanId = (int)cbDanismanOgrenci.SelectedValue;
                    newOgrenci.DiplomaId = (int)cbOgrenciDiplama.SelectedValue;
                    _db.Orenciler.Add(newOgrenci);
                    _db.SaveChanges();
                    OgrenciGoster();
                    break;
                case "dersEkle":
                    Ders newders = new Ders();
                    newders.Name = dersAdi.Text;
                    newders.Kod = dersKodu.Text;
                    newders.Kredi = Convert.ToInt32(txtKredi.Text);
                    _db.Dersler.Add(newders);
                    _db.SaveChanges();
                    DersGoster();
                    break;

            }
        }

        private void btnUpdate(object sender, EventArgs e)
        {
            var buttonTag = (Button)sender;
            switch (buttonTag.Tag)
            {
                case "danismanGuncelle":
                    int id = IdFounder(dataGridDanisman);
                    var updateDanisman = _db.Danismanlar.FirstOrDefault(d => d.ID == id);
                    updateDanisman.Name = txtDanismanAd.Text;
                    updateDanisman.Surname = txtDanismanSoyad.Text;
                    _db.Danismanlar.Update(updateDanisman);
                    _db.SaveChanges();
                    DanismanGuncelle();
                    break;
                case "ogrenciGuncelle":
                    int id2 = IdFounder(dataGridOgrenci);
                    var updateOgrenci = _db.Orenciler.FirstOrDefault(d => d.Id == id2);
                    updateOgrenci.Name = txtOgrenciAd.Text;
                    updateOgrenci.Surname = txtOgrenciSoyad.Text;
                    updateOgrenci.BirthDay = dtOgrenciPiker.Value;
                    updateOgrenci.DanismanId = (int)cbDanismanOgrenci.SelectedValue;
                    updateOgrenci.DiplomaId = (int)cbOgrenciDiplama.SelectedValue;
                    _db.Orenciler.Update(updateOgrenci);
                    _db.SaveChanges();
                    OgrenciGoster();
                    break;
                case "dersGuncelle":
                    int idDers = IdFounder(dataGridDers);
                    var updateDers = _db.Dersler.FirstOrDefault(d => d.Id == idDers);
                    updateDers.Name = dersAdi.Text;
                    updateDers.Kod = dersKodu.Text;
                    updateDers.Kredi = Convert.ToInt32(txtKredi.Text);
                    _db.Dersler.Update(updateDers);
                    _db.SaveChanges(true);
                    break;
            }

        }
        private void BtnDelete(object sender, EventArgs e)
        {
            var buttonTag = sender as Button;
            switch (buttonTag.Tag)
            {
                case "DanismanDelete":
                    int idDanisman = IdFounder(dataGridDanisman);
                    var deleteDanisman = _db.Danismanlar.FirstOrDefault(d => d.ID == idDanisman);
                    _db.Danismanlar.Remove(deleteDanisman);
                    _db.SaveChanges();
                    DanismanGuncelle();
                    OgrenciGoster();
                    break;
                case "OgrenciDelete":
                    int idOgrenci = IdFounder(dataGridOgrenci);
                    var deleteOgrenci = _db.Orenciler.FirstOrDefault(og => og.Id == idOgrenci);
                    _db.Orenciler.Remove(deleteOgrenci);
                    _db.SaveChanges();
                    OgrenciGoster();
                    break;
                case "dersSil":
                    int idDers = IdFounder(dataGridDers);
                    var deleteDers = _db.Dersler.FirstOrDefault(de => de.Id == idDers);
                    _db.Dersler.Remove(deleteDers);
                    _db.SaveChanges();
                    DersGoster();
                    break;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Diploma diploma = new Diploma();
                diploma.No = txtNo.Text;
                diploma.Tarih = dtTimeTarih.Value;

                _db.Diplomas.Add(diploma);
                _db.SaveChanges();

                MessageBox.Show("Basriyla Eklenmistir");
                DiplomalariGoster();

                secilenDiploma = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata Olustu: {ex.Message}");
            }
        }

        private void dataGridDiploamalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDiploma = (Diploma)dataGridDiploamalar.SelectedRows[0].DataBoundItem;
            txtNo.Text = secilenDiploma.No;
            dtTimeTarih.Value = secilenDiploma.Tarih;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Gride Tiklaninca diplomayi sececek.
            //Tiklamadna guncellemeye basarsa diye if blogunu ekledik
            try
            {
                if (secilenDiploma != null) //gride tiklandiysa (secilen diploma varsa)
                {
                    secilenDiploma.No = txtNo.Text;
                    secilenDiploma.Tarih = dtTimeTarih.Value;
                    _db.Diplomas.Update(secilenDiploma);
                    _db.SaveChanges(true);
                    DiplomalariGoster();

                    MessageBox.Show("Basriyla Guncellenmistir");
                    secilenDiploma = null;
                }
                else
                {
                    MessageBox.Show("Guncellemek icin lutfen diploma seciniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata Olustu: {ex.Message}");

            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenDiploma != null)
                {
                    _db.Diplomas.Remove(secilenDiploma);
                    _db.SaveChanges();
                    DiplomalariGoster();

                    dataGridDiploamalar.Rows[0].Selected = false;
                    dataGridDiploamalar.Rows[dataGridDiploamalar.RowCount - 1].Selected = true;
                    MessageBox.Show("Basriyla Silinmist");
                }
                else
                {
                    MessageBox.Show("Silmek icin lutfen diploma seciniz");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata Olustu: {ex.Message}");
            }
        }

        private void dataGridDanisman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDanisman = (Danisman)dataGridDanisman.SelectedRows[0].DataBoundItem;
            txtDanismanAd.Text = secilenDanisman.Name;
            txtDanismanSoyad.Text = secilenDanisman.Surname;
        }
        private void OgrenciComboGoster()
        {
            comboOgreci2.DataSource = _db.Orenciler.ToList();
            comboOgreci2.DisplayMember = "NameSurname";
            comboOgreci2.ValueMember = "Id";
        }
        private void DersComboGoster()
        {
            comboDers2.DataSource = _db.Dersler.ToList();
            comboDers2.DisplayMember = "Kod";
            comboDers2.ValueMember = "Id";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrenciDers ogrenciDers = new OgrenciDers();
            ogrenciDers.DersId = (int)comboDers2.SelectedValue;
            ogrenciDers.OgrenciId = (int)comboOgreci2.SelectedValue;
            ogrenciDers.Not = txtNo.Text;   
            _db.OgrenciDerses.Add(ogrenciDers);
            _db.SaveChanges();  
        }
    }
}
