namespace UniversiteCodeFirst
{
    public partial class DiplomaFormu : Form
    {
        OkulDbContext _db = new OkulDbContext();
        Diploma secilenDiploma;
        public DiplomaFormu()
        {
            InitializeComponent();
            DiplomalariGoster();//açılışta gritte gostermesi için
        }

        private void DiplomalariGoster()
        {
            dgwDiplomalar.DataSource = null;
            dgwDiplomalar.DataSource = _db.Diplomalar.ToList();
            if (dgwDiplomalar.Columns[0].Visible)
                dgwDiplomalar.Columns[0].Visible = false;
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
                MessageBox.Show("başarıyla eklenmiştir");

            }
            catch (Exception)
            {


            }

        }

        private void dgwDiplomalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDiploma = (Diploma)dgwDiplomalar.SelectedRows[0].DataBoundItem;
            txtNo.Text=secilenDiploma.No;
            txtTarih.Text=secilenDiploma.Tarih.ToShortDateString();

            lblScilenDiploma.Text=secilenDiploma.No;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenDiploma != null)
                {
                    secilenDiploma.No = txtNo.Text;
                    secilenDiploma.Tarih = Convert.ToDateTime(txtTarih.Text);

                    _db.SaveChanges();
                    DiplomalariGoster();
                    secilenDiploma = null;
                    lblScilenDiploma.Text = "seçilen diploma";
                }
                else
                    MessageBox.Show("lütfen diploma seçiniz");
                 }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu"+ ex.Message);


            }

        }
        }
    }

