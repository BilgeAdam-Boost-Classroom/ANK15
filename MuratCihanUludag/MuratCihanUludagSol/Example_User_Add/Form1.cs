using Example_User_Add.Models;
using System.Windows.Forms;

namespace Example_User_Add
{
    public partial class Form1 : Form
    {
        UniversiteDbContext _db = new UniversiteDbContext();
        public Form1()
        {
            InitializeComponent();
            DataLoad();
        }
        private void DataLoad()
        {
            dataGridV1.ColumnCount = 3;
            dataGridV1.Columns[0].Name = "Id";
            dataGridV1.Columns[1].Name = "Name";
            dataGridV1.Columns[2].Name = "SurName";
            dataGridV1.Rows.Clear();
            foreach (var item in _db.Danismanlars)
            {
                dataGridV1.Rows.Add(item.Id, item.Ad, item.Soyad);
            }

        }
        private object IdFounder()
        {
            int row = dataGridV1.SelectedCells[0].RowIndex;
            object selectId = dataGridV1.Rows[row].Cells[0].Value;
            return selectId;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Danismanlar newDanisman = new Danismanlar();
            newDanisman.Ad = textName.Text;
            newDanisman.Soyad = textSurname.Text;
            _db.Danismanlars.Add(newDanisman);
            _db.SaveChanges();
            DataLoad();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = (int)IdFounder();
            var updateDanisman = _db.Danismanlars.FirstOrDefault(d => d.Id == id);
            updateDanisman.Ad = textName.Text;
            updateDanisman.Soyad = textSurname.Text;
            _db.SaveChanges();
            DataLoad();
        }

        private void btn_dalate_Click(object sender, EventArgs e)
        {
            int id = (int)IdFounder();
            var deleteDanisman = _db.Danismanlars.FirstOrDefault(d => d.Id == id);
            _db.Danismanlars.Remove(deleteDanisman);
            _db.SaveChanges();
            DataLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.ShowDialog();   
        }
    }
}
