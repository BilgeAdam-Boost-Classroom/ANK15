using System.Windows.Forms;

namespace Odev6_Araba
{
    public partial class Form1 : Form
    {
        List<Araba> arabalar = new List<Araba>()
        {
            new Araba() { Marka = "A", Model = "A1", Renk = "Siyah", UretimYili = "2010" },
            new Araba() { Marka = "B", Model = "B1", Renk = "Siyah", UretimYili = "2020" },
            new Araba() { Marka = "C", Model = "C1", Renk = "Mavi", UretimYili = "2016" },
            new Araba() { Marka = "D", Model = "D1", Renk = "Metalik Gri", UretimYili = "2018" }
        };

        public Form1()
        {
            InitializeComponent();
            foreach (Araba araba in arabalar)
            {
                lbAraba.Items.Add($"{araba.Marka} - {araba.Model}");
            }
        }

        private void lbAraba_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] selectedItem = lbAraba.SelectedItem.ToString().Split(" - ");
            Araba selectedCar = arabalar.Where(araba => araba.Marka == selectedItem[0] && araba.Model == selectedItem[1]).First();
            labelAraba.Text = selectedCar.OzellikleriYaz();
        }
    }
}