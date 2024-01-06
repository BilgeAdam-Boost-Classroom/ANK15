using OkulExerciseWF.Entity;
using SchoolExercise;

namespace OkulExerciseWF
{
    public partial class DanismanForm : Form
    {
        SchoolDbContext context = new SchoolDbContext();
        public DanismanForm()
        {
            InitializeComponent();
            VerileriGetir();
        }
        private void VerileriGetir()
        {
            dataGridView1.DataSource = context.Danismanlar.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var danisman = new Entity.Danisman();
            danisman.Ad = txtbxAd.Text;
            danisman.Soyad = txtbxSoyad.Text;
            context.Add(danisman);
            context.SaveChanges();

            VerileriGetir();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            var danisman = (Entity.Danisman)dataGridView1.SelectedRows[0].DataBoundItem;
            danisman.Ad = txtbxAd.Text;
            danisman.Soyad = txtbxSoyad.Text;
            context.Update(danisman);
            context.SaveChanges();

            VerileriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var danisman = (Entity.Danisman)dataGridView1.SelectedRows[0].DataBoundItem;
            context.Remove(danisman);
            context.SaveChanges();

            VerileriGetir();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var danisman = (Entity.Danisman)dataGridView1.SelectedRows[0].DataBoundItem;
            txtbxAd.Text = danisman.Ad;
            txtbxSoyad.Text = danisman.Soyad;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
