namespace CodeFirstUniversite
{
    public partial class DiplomaEkrani : Form
    {
        OkulDbContext _db = new OkulDbContext();
        Diploma secilenDiploma;
        public DiplomaEkrani()
        {
            InitializeComponent();
            DiplomalariGoster();
        }

        private void DiplomalariGoster()
        {
            dgvDiplomalar.DataSource = null;
            dgvDiplomalar.DataSource = _db.Diplomas.ToList();
            if (dgvDiplomalar.Columns[0].Visible)
                dgvDiplomalar.Columns[0].Visible = false;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                Diploma diploma = new Diploma();
                diploma.No = txtNo.Text;
                diploma.Tarih = Convert.ToDateTime(txtTarih.Text);

                _db.Diplomas.Add(diploma);
                _db.SaveChanges();
                DiplomalariGoster();
                MessageBox.Show("Baþarý ile eklendi.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
            }

        }

        private void dgvDiplomalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDiploma = (Diploma)dgvDiplomalar.SelectedRows[0].DataBoundItem;
            txtNo.Text = secilenDiploma.No;
            txtTarih.Text = secilenDiploma.Tarih.ToShortDateString();
            lblSecilen.Text = "Secilen Diploma: " + secilenDiploma.No;
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
                    lblSecilen.Text = "Secilen Diploma: ";
                    MessageBox.Show("Baþari ile güncellendi.");
                }

                else
                {
                    MessageBox.Show("Lutfen diploma seçiniz");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try 
            { 
                if(secilenDiploma != null)
                {
                    _db.Diplomas.Remove(secilenDiploma);
                    _db.SaveChanges();

                    DiplomalariGoster();

                    secilenDiploma = null;
                    lblSecilen.Text = "Secilen Diploma: ";
                    MessageBox.Show("Baþari ile silinmiþtir");

                }

                else
                {
                    MessageBox.Show("Lutfen diploma seciniz");
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluþtu " + ex.Message);

            }   
        }
    }
}