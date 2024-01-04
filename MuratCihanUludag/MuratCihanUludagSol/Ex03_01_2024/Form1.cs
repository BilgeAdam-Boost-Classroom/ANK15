using Ex03_01_2024.Context;
using Ex03_01_2024.Models;

namespace Ex03_01_2024
{
    public partial class Form1 : Form
    {
        OkulDbContext _db = new OkulDbContext();
        Diploma secilenDiploma;
        public Form1()
        {
            InitializeComponent();
            //Acilista da giri'de gosterilsin
            DiplomalariGoster();
        }
        private void DiplomalariGoster()
        {
            dataGridDiploamalar.DataSource = null;
            dataGridDiploamalar.DataSource = _db.Diplomas.ToList();

            dataGridDiploamalar.Columns["Id"].Visible = false; // Id yi Goster
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
            catch(Exception ex) 
            {
                MessageBox.Show($"Hata Olustu: {ex.Message}");
            }
        }
    }
}
