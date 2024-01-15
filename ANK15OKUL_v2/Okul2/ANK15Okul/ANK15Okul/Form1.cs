using ANK15Okul.Concrete;
using ANK15Okul.Context;
using Microsoft.EntityFrameworkCore;

namespace ANK15Okul
{
    public partial class Form1 : Form
    {
        Ank15OkulDbContext _db = new Ank15OkulDbContext();
        Diploma secilenDiploma;
        public Form1()
        {
            InitializeComponent();


            //Açılışta da grid'de göstersin
            DiplomalariGoster();


            //Kendisi many to many oluşturduğu zaman, ekleme yapmak için listeye ekleyip (add) ,savechages'ı çağırmak; kaldırmak için de listeden remove yapıp yine savechanges'ı çağırmak yeterlidir. (listenin en başta new'lenmesi gereklidir. Aşağıdaki örnekte liste sınıfın içerisinde newlenmiştir.)

            var ogrenci = _db.Ogrenciler.Include(o=>o.Dersler).FirstOrDefault(o => o.Id == 2);
            var ders = _db.Dersler.FirstOrDefault(o => o.Id == 2);



            //ogrenci.Dersler = new List<Ders>();

            ogrenci.Dersler.Add(ders);
            _db.SaveChanges();

        }

        private void DiplomalariGoster()
        {
            dgvDiplomalar.DataSource = null;
            dgvDiplomalar.DataSource = _db.Diplomalar.ToList();

            if (dgvDiplomalar.Columns[0].Visible)
                dgvDiplomalar.Columns[0].Visible = false; //id 'yi gösterme

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Diploma diploma = new Diploma();
                diploma.No = txtNo.Text;
                diploma.Tarih = Convert.ToDateTime(txtTarih.Text);

                _db.Diplomalar.Add(diploma);
                _db.SaveChanges();
                DiplomalariGoster();
                MessageBox.Show("Başarıyla eklemiştir");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu " + ex.Message);
            }


        }

        private void dgvDiplomalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seç
            secilenDiploma = (Diploma)dgvDiplomalar.SelectedRows[0].DataBoundItem;

            //bilgilerini textboxlarda çıkart
            txtNo.Text = secilenDiploma.No;
            txtTarih.Text = secilenDiploma.Tarih.ToShortDateString();

            //seçilen label'ına bilgiyi yazdır
            lblSecilenDiploma.Text = "Seçilen Diplama " + secilenDiploma.No;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //gride tıklanınca diplomayı seçecek.
            //Tıklamadan güncellemeye basarsa diye aşağıdaki if bloğunu ekliyoruz.

            try
            {
                if (secilenDiploma != null)  //gride tıklandıysa (seçilen diploma varsa)
                {
                    secilenDiploma.No = txtNo.Text;
                    secilenDiploma.Tarih = Convert.ToDateTime(txtTarih.Text);

                    _db.SaveChanges();
                    DiplomalariGoster();

                    //seçileni null yap ki bundan sonraki güncellemede kişi, yine grid'e tıklasın
                    secilenDiploma = null;
                    lblSecilenDiploma.Text = "Seçilen Diploma: ";
                    MessageBox.Show("Başarıyla güncellenmiştir");
                }
                else
                    MessageBox.Show("Lütfen güncellemek için diploma seçiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu " + ex.Message);
            }



        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                //seçilen varsa sil.
                if (secilenDiploma != null)
                {
                    _db.Diplomalar.Remove(secilenDiploma);
                    _db.SaveChanges();

                    DiplomalariGoster();

                    //seçileni null yap ki bundan sonraki silmede kişi, yine grid'e tıklasın
                    secilenDiploma = null;
                    lblSecilenDiploma.Text = "Seçilen Diploma: ";
                    dgvDiplomalar.Rows[0].Selected = false;
                    dgvDiplomalar.Rows[dgvDiplomalar.Rows.Count - 1].Selected = true;
                    MessageBox.Show("Başarıyla silinmiştir");
                }
                else
                    MessageBox.Show("Lütfen silmek için diploma seçiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu " + ex.Message);
            }
        }
    }
}