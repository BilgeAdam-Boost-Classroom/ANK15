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
                MessageBox.Show("Ba�ar�yla Kaydedilmi�tir.");

            }
            catch (Exception ex)
            {

                MessageBox.Show("hata olu�tur" + ex.Message);
            }

        }

        private void dgvDiplomalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //se�
            SecilenDiploma = (Diploma)dgvDiplomalar.SelectedRows[0].DataBoundItem;
            //bilgileri textboxa aktar
            txtDiplomaNo.Text =Convert.ToString(SecilenDiploma.No);
            txtDiplomaTarih.Text = SecilenDiploma.Tarih.ToShortDateString().ToString();

           

        }

        private void btnG�ncelle_Click(object sender, EventArgs e)
        {
            //gride t�klan�nca se�icek ama t�klamadan g�ncelleye asarsa diye a�a��daki if blo�unu ekliyoruz.

            if (SecilenDiploma!=null)
            {
                SecilenDiploma.No =Convert.ToInt32( txtDiplomaNo.Text);
                SecilenDiploma.Tarih =Convert.ToDateTime( txtDiplomaTarih.Text);


                _db.SaveChanges();
                DiplomaGoster();
                //se�ileni null yapki bundan sonraki g�ncellemede ki�i yine gride t�klas�n
                SecilenDiploma = null;
                label1.Text = "Se�ilen Diploma : ";
                MessageBox.Show("Ba�ar�yla G�ncellenmi�tir");
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
                    label1.Text = "Se�ilen Diploma :";
                    MessageBox.Show("ba�ar�yla Silinmi�tir");
                }
                else
                {
                    MessageBox.Show("L�tfen silmek i�in diploma se�iniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("hata olu�tur" + ex.Message);
            }
        }
    }
}
