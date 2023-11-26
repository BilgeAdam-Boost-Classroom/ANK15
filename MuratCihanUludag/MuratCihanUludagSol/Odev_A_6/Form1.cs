namespace Odev_A_6
{
    public partial class Form1 : Form
    {
        Araba araba1 = new Araba() { Marka = "A", Model = "A1", Renk = "Siyah", UretimYili = "2010" };
        Araba araba2 = new Araba() { Marka = "B", Model = "B1", Renk = "Siyah", UretimYili = "2020" };
        Araba araba3 = new Araba() { Marka = "C", Model = "C1", Renk = "Mavi", UretimYili = "2016" };
        Araba araba4 = new Araba() { Marka = "D", Model = "D1", Renk = "Metalic Gri", UretimYili = "2018" };
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(araba1.ToString());
            listBox1.Items.Add(araba2.ToString());
            listBox1.Items.Add(araba3.ToString());
            listBox1.Items.Add(araba4.ToString());
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


            }
       
             
        }
    }
}