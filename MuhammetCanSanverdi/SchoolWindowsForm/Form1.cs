namespace SchoolWindowsForm
{
    public partial class Form1 : Form
    {
        ANK15OkulDbContext _context = new();
        Diploma secilenDiploma;
        public Form1()
        {
            InitializeComponent();
            DiplomalariGoster();
        }
        private void DiplomalariGoster()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _context.Diplomalar.ToList();
            if (dataGridView1.Columns[0].Visible)
                dataGridView1.Columns[0].Visible = false;

        }
        private void TextleriBosalt()
        {
            txtbxNo.Text ="";
            txtbxTarih.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Diploma diploma = new Diploma();
                diploma.No = txtbxNo.Text;
                diploma.Tarih = Convert.ToDateTime(txtbxTarih.Text);

                _context.Diplomalar.Add(diploma);
                _context.SaveChanges();
                MessageBox.Show("Baþarýyla Eklenmiþtir");
                DiplomalariGoster();
                secilenDiploma = null;
                TextleriBosalt();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata oluþtu" + ex.Message);
            }

        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDiploma = (Diploma)dataGridView1.SelectedRows[0].DataBoundItem;
            txtbxNo.Text = secilenDiploma.No;
            txtbxTarih.Text = secilenDiploma.Tarih.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenDiploma is not null)
                {
                    secilenDiploma.No = txtbxNo.Text;
                    secilenDiploma.Tarih = Convert.ToDateTime(txtbxTarih.Text);

                    _context.Diplomalar.Update(secilenDiploma);
                    _context.SaveChanges();
                    MessageBox.Show("Baþarýyla Güncellenmiþtir");
                    DiplomalariGoster();
                    secilenDiploma = null;
                    TextleriBosalt();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata oluþtu" + ex.Message);
            }
            
        }
    }
}
