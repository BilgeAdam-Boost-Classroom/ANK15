namespace ArabaFom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Araba araba1, araba2, araba3, araba4;
        private void Form1_Load(object sender, EventArgs e)
        {
            araba1 = new Araba()
            {
                Marka = "A",
                Model = "A1",
                Renk = "SÝYAH",
                UretimYili = "2010"
            };
            araba2 = new Araba()
            {
                Marka = "B",
                Model = "B1",
                Renk = "SÝYAH",
                UretimYili = "2020"
            };
            araba3 = new Araba()
            {
                Marka = "C",
                Model = "C1",
                Renk = "MAVÝ",
                UretimYili = "2016"
            };
            araba4 = new Araba()
            {
                Marka = "D",
                Model = "D1",
                Renk = "METALÝK GRÝ",
                UretimYili = "2018"
            };
            listBox1.Items.Add(araba1.Marka + "-" + araba1.Model);
            listBox1.Items.Add(araba2.Marka + "-" + araba2.Model);
            listBox1.Items.Add(araba3.Marka + "-" + araba3.Model);
            listBox1.Items.Add(araba4.Marka + "-" + araba4.Model);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = araba1.OzellikleriYaz();
                    break;
                case 1:
                    label1.Text = araba2.OzellikleriYaz();
                    break;
                case 2:
                    label1.Text = araba3.OzellikleriYaz();
                    break;
                case 3:
                    label1.Text = araba4.OzellikleriYaz();
                    break;
                default:
                    break;
            }
        }
    }
}