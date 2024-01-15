using Odev13Main;
using Microsoft.EntityFrameworkCore;
using Ödev_A_13.Cont;
using Ödev_A_13.Model;

namespace Odev13Main
{
    public partial class Form1 : Form
    {
        CarDbContext _db = new CarDbContext();
        LicencePlate slicencePlate;
        Person sPerson;
        Engineer sEngineer;
        Car sCar;
        public Form1()
        {
            InitializeComponent();
            ShowTime();
            cbxLP.Items.AddRange(_db.LicencePlates.ToArray());
            cbxPersons.Items.AddRange(_db.Persons.ToArray());
            lbxEngineers.Items.AddRange(_db.Engineers.ToArray());
        }

        void ShowTime()
        {
            dgvLP.DataSource = null;
            dgvLP.DataSource = _db.LicencePlates.ToList();
            dgvCars.DataSource = null;
            dgvCars.DataSource = _db.Cars.ToList();
            dgvPersons.DataSource = null;
            dgvPersons.DataSource = _db.Persons.ToList();
            dgvEngineers.DataSource = null;
            dgvEngineers.DataSource = _db.Engineers.ToList();
        }

        private void btnLPEkle_Click(object sender, EventArgs e)
        {
            LicencePlate licence = new LicencePlate();
            licence.PlateNumber = txtPlate.Text;
            _db.Add(licence);
            _db.SaveChanges();
            ShowTime();
        }

        private void btnCarEkle_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Name = txtCarName.Text;
            car.LicencePlateId = ((LicencePlate)(cbxLP.SelectedItem)).Id;
            car.PersonId = ((Person)(cbxPersons.SelectedItem)).Id;
            List<Engineer> engineers = new();
            engineers.AddRange((((Engineer)lbxEngineers.SelectedItems).Id).);



        }

        private void btnPersonEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnEngineersEkle_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
