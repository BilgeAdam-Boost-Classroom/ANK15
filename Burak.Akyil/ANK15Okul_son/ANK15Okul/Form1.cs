using ANK15Okul.Concrete;
using ANK15Okul.Concrete;
using ANK15Okul.Context;

namespace ANK15Okul
{
    public partial class Form1 : Form
    {
        Ank15OkulDbContext _db = new Ank15OkulDbContext();
        Danisman secilenDanisman;
        Ders secilenDers;
        Diploma secilenDiploma;
        public Form1()
        {
            InitializeComponent();


            //Açılışta da grid'de göstersin
            DiplomalariGoster();
            DersleriGoster();
            DanismanlariGoster();
        }

        private void DiplomalariGoster()
        {
            dgvDiplomalar.DataSource = null;
            dgvDiplomalar.DataSource = _db.Diplomalar.ToList();

            if (dgvDiplomalar.Columns[0].Visible)
                dgvDiplomalar.Columns[0].Visible = false; //id 'yi gösterme

        }

        private void DersleriGoster()
        {
            dgvDersler.DataSource = null;
            dgvDersler.DataSource = _db.Dersler.ToList();

            if (dgvDersler.Columns[0].Visible)
                dgvDersler.Columns[0].Visible = false; //id 'yi gösterme

        }

        private void DanismanlariGoster()
        {
            dgvDanismanlar.DataSource = null;
            dgvDanismanlar.DataSource = _db.Danismanlar.ToList();

            if (dgvDanismanlar.Columns[0].Visible)
                dgvDanismanlar.Columns[0].Visible = false; //id 'yi gösterme

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNo.Text))
                {
                    MessageBox.Show("Diploma No Boş Olamaz!");
                    return;
                }

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
                if (string.IsNullOrWhiteSpace(txtNo.Text))
                {
                    MessageBox.Show("Diploma No Boş Olamaz!");
                    return;
                }

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
                    if (dgvDiplomalar.Rows.Count > 0)
                    {
                        dgvDiplomalar.Rows[0].Selected = false;
                        dgvDiplomalar.Rows[dgvDiplomalar.Rows.Count - 1].Selected = true;
                    }

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

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtDersAd.Text) ||
                   string.IsNullOrWhiteSpace(txtDersKod.Text) ||
                   string.IsNullOrWhiteSpace(txtDersKredi.Text))
                {
                    MessageBox.Show("Ders alanlarını lütfen boş geçmeyiniz");
                    return;
                }


                Ders ders = new Ders();
                ders.Ad = txtDersAd.Text;
                ders.Kod = txtDersKod.Text;
                ders.Kredi = Convert.ToInt32(txtDersKredi.Text);

                _db.Dersler.Add(ders);
                _db.SaveChanges();

                DersleriGoster();

                MessageBox.Show("Ders başarıyla eklenmiştir");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu " + ex.Message);
            }
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            //gride tıklanınca diplomayı seçecek.
            //Tıklamadan güncellemeye basarsa diye aşağıdaki if bloğunu ekliyoruz.

            try
            {
                if (string.IsNullOrWhiteSpace(txtDersAd.Text) ||
                  string.IsNullOrWhiteSpace(txtDersKod.Text) ||
                  string.IsNullOrWhiteSpace(txtDersKredi.Text))
                {
                    MessageBox.Show("Ders alanlarını lütfen boş geçmeyiniz");
                    return;
                }
                if (secilenDers != null)  //gride tıklandıysa (seçilen diploma varsa)
                {
                    secilenDers.Ad = txtDersAd.Text;
                    secilenDers.Kod = txtDersKod.Text;
                    secilenDers.Kredi = Convert.ToInt32(txtDersKredi.Text);



                    _db.SaveChanges();
                    DersleriGoster();

                    //seçileni null yap ki bundan sonraki güncellemede kişi, yine grid'e tıklasın
                    secilenDers = null;
                    lblSecilenDers.Text = "Seçilen Ders: ";
                    MessageBox.Show("Başarıyla güncellenmiştir");
                }
                else
                    MessageBox.Show("Lütfen güncellemek için ders seçiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu " + ex.Message);
            }
        }

        private void dgvDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seç
            secilenDers = (Ders)dgvDersler.SelectedRows[0].DataBoundItem;

            //bilgilerini textboxlarda çıkart
            txtDersAd.Text = secilenDers.Ad;
            txtDersKod.Text = secilenDers.Kod;
            txtDersKredi.Text = secilenDers.Kredi.ToString();

            //seçilen label'ına bilgiyi yazdır
            lblSecilenDers.Text = "Seçilen Ders " + secilenDers.Ad + " " + secilenDers.Kod;
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            try
            {
                //seçilen varsa sil.
                if (secilenDers != null)
                {
                    _db.Dersler.Remove(secilenDers);
                    _db.SaveChanges();

                    DersleriGoster();

                    //seçileni null yap ki bundan sonraki silmede kişi, yine grid'e tıklasın
                    secilenDers = null;
                    lblSecilenDers.Text = "Seçilen Ders: ";
                    if (dgvDersler.Rows.Count > 0)
                    {
                        dgvDersler.Rows[0].Selected = false;
                        dgvDersler.Rows[dgvDiplomalar.Rows.Count - 1].Selected = true;
                    }

                    MessageBox.Show("Başarıyla silinmiştir");
                }
                else
                    MessageBox.Show("Lütfen silmek için ders seçiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu " + ex.Message);
            }
        }

        private void btnDanismanEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDanismanAd.Text) ||
                  string.IsNullOrWhiteSpace(txtDanismanSoyad.Text))
                {
                    MessageBox.Show("Danışman alanlarını lütfen boş geçmeyiniz");
                    return;
                }

                Danisman danisman = new Danisman();
                danisman.Ad = txtDanismanAd.Text;
                danisman.Soyad = txtDanismanSoyad.Text;

                _db.Danismanlar.Add(danisman);
                _db.SaveChanges();
                DanismanlariGoster();
                MessageBox.Show("Başarıyla eklemiştir");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu " + ex.Message);
            }
        }

        private void btnDanismanSil_Click(object sender, EventArgs e)
        {
            try
            {
                //seçilen varsa sil.
                if (secilenDanisman != null)
                {
                    _db.Danismanlar.Remove(secilenDanisman);
                    _db.SaveChanges();

                    DanismanlariGoster();

                    //seçileni null yap ki bundan sonraki silmede kişi, yine grid'e tıklasın
                    secilenDanisman = null;
                    lblSecilenDanisman.Text = "Seçilen Danışman: ";
                    if (dgvDanismanlar.Rows.Count > 0)
                    {
                        dgvDanismanlar.Rows[0].Selected = false;
                        dgvDanismanlar.Rows[dgvDiplomalar.Rows.Count - 1].Selected = true;
                    }

                    MessageBox.Show("Başarıyla silinmiştir");
                }
                else
                    MessageBox.Show("Lütfen silmek için danışman seçiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu " + ex.Message);
            }
        }

        private void btnDanismanGuncelle_Click(object sender, EventArgs e)
        {
            //gride tıklanınca diplomayı seçecek.
            //Tıklamadan güncellemeye basarsa diye aşağıdaki if bloğunu ekliyoruz.

            try
            {
                if (string.IsNullOrWhiteSpace(txtDanismanAd.Text) ||
                 string.IsNullOrWhiteSpace(txtDanismanSoyad.Text))
                {
                    MessageBox.Show("Danışman alanlarını lütfen boş geçmeyiniz");
                    return;
                }
                if (secilenDanisman != null)  //gride tıklandıysa (seçilen diploma varsa)
                {
                    secilenDanisman.Ad = txtDanismanAd.Text;
                    secilenDanisman.Soyad = txtDanismanSoyad.Text;
                    _db.SaveChanges();
                    DanismanlariGoster();

                    //seçileni null yap ki bundan sonraki güncellemede kişi, yine grid'e tıklasın
                    secilenDanisman = null;
                    lblSecilenDanisman.Text = "Seçilen Danışman: ";

                    MessageBox.Show("Başarıyla güncellenmiştir");
                }
                else
                    MessageBox.Show("Lütfen güncellemek için danışman seçiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu " + ex.Message);
            }
        }

        private void dgvDanismanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seç
            secilenDanisman = (Danisman)dgvDanismanlar.SelectedRows[0].DataBoundItem;

            //bilgilerini textboxlarda çıkart
            txtDanismanAd.Text = secilenDanisman.Ad;
            txtDanismanSoyad.Text = secilenDanisman.Soyad;

            //seçilen label'ına bilgiyi yazdır
            lblSecilenDanisman.Text = "Seçilen Danışman " + Environment.NewLine + secilenDanisman.Ad + " " + secilenDanisman.Soyad;
        }

        private void btnOgrenciEkrani_Click(object sender, EventArgs e)
        {
            OgrenciEkranForm ogrenciEkranForm = new OgrenciEkranForm(_db);
            ogrenciEkranForm.ShowDialog();
        }
    }
}