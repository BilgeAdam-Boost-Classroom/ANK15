namespace codeFirstokul
{
    public partial class Form1 : Form
    {
        OkulDbContext _db = new OkulDbContext();
        Diploma SecilenDiploma;
        public Form1()
        {
            InitializeComponent();

            DiplomaGoster();
        }
        private void DiplomaGoster()
        {
            dgvDiplomalar.DataSource = null;
            dgvDiplomalar.DataSource = _db.Diplomalars.ToList();
            if (dgvDiplomalar.Columns[0].Visible)
                dgvDiplomalar.Columns[0].Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Diploma diploma = new Diploma();
                diploma.No = Convert.ToInt32(txtDiplomaNo.Text);
                diploma.Tarih = Convert.ToDateTime(txtDiplomaTarih.Text);

                _db.Diplomalars.Add(diploma);
                _db.SaveChanges();
                DiplomaGoster();
                MessageBox.Show("Baþarýyla Kaydedilmiþtir.");

            }
            catch (Exception ex)
            {

                MessageBox.Show("hata oluþtur" + ex.Message);
            }

        }

        private void dgvDiplomalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seç
            SecilenDiploma = (Diploma)dgvDiplomalar.SelectedRows[0].DataBoundItem;
            //bilgileri textboxa aktar
            txtDiplomaNo.Text =Convert.ToString(SecilenDiploma.No);
            txtDiplomaTarih.Text = SecilenDiploma.Tarih.ToShortDateString().ToString();

           

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            //gride týklanýnca seçicek ama týklamadan güncelleye asarsa diye aþaðýdaki if bloðunu ekliyoruz.

            if (SecilenDiploma!=null)
            {
                SecilenDiploma.No =Convert.ToInt32( txtDiplomaNo.Text);
                SecilenDiploma.Tarih =Convert.ToDateTime( txtDiplomaTarih.Text);


                _db.SaveChanges();
                DiplomaGoster();
                //seçileni null yapki bundan sonraki güncellemede kiþi yine gride týklasýn
                SecilenDiploma = null;
                label1.Text = "Seçilen Diploma : ";
                MessageBox.Show("Baþarýyla Güncellenmiþtir");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (SecilenDiploma!=null)
                {
                    _db.Diplomalars.Remove(SecilenDiploma);
                    _db.SaveChanges();

                    DiplomaGoster();

                    SecilenDiploma = null;
                    label1.Text = "Seçilen Diploma :";
                    MessageBox.Show("baþarýyla Silinmiþtir");
                }
                else
                {
                    MessageBox.Show("Lütfen silmek için diploma seçiniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("hata oluþtur" + ex.Message);
            }
        }
    }
}
