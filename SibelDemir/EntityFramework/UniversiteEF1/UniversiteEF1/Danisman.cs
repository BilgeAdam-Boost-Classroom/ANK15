using UniversiteEF1.Models;

namespace UniversiteEF1
{


    public partial class Danisman : Form
    {
        UniversiteDbContext _db = new UniversiteDbContext();
        Danismanlar secilenDanisman;


        public Danisman()
        {
            InitializeComponent();
            Goster();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            Danismanlar danisan = new Danismanlar();
            danisan.Ad = ad;
            danisan.Soyad = soyad;
            _db.Danismanlars.Add(danisan);
            _db.SaveChanges();
            Goster();
            MessageBox.Show("veritabanına eklenmiştir");

        }
        private void Goster()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _db.Danismanlars.ToList()
;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //eğer seçilen danışman varsa!!
            //eğer gride tıklanmadan bu butona tıklanırsa seçilen danışman null olur
            //o zamn da günncelleyemez

            if (secilenDanisman != null)
            {
                secilenDanisman.Ad = txtAd.Text;
                secilenDanisman.Soyad = txtSoyad.Text;

                _db.SaveChanges();
                MessageBox.Show("başarıyla güncellenmiştir");
                secilenDanisman = null;
                label3.Text = "Seçilen Danışman:";
                Goster();

            }
            else
                MessageBox.Show("danışman seç");
        }
        //gritte tıklandığı
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tıklandığı zaman seçilendanışmanı gridden al
            secilenDanisman = (Danismanlar)dataGridView1.SelectedRows[0].DataBoundItem; //satırdaki tıklanan
            txtAd.Text = secilenDanisman.Ad;
            txtSoyad.Text = secilenDanisman.Soyad;

            label3.Text = "Seçilen Danışman:" + secilenDanisman.Ad + " " + secilenDanisman.Soyad;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenDanisman != null)
            {
                _db.Danismanlars.Remove(secilenDanisman);
                

                _db.SaveChanges();
                MessageBox.Show("başarıyla silinmiştir");
                secilenDanisman = null;
                label3.Text = "Seçilen Danışman:";
                Goster();

            }
            else
                MessageBox.Show("danışman seç");
        }
    }
}
