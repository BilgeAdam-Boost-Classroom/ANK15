namespace Odev7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("A - A1");
            listBox1.Items.Add("B - B1");
            listBox1.Items.Add("C - C1");
            listBox1.Items.Add("D - D1");

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Araba araba1 = new Araba();
            araba1.Marka = "A";
            araba1.Model = "A1";
            araba1.Renk = "Siyah";
            araba1.UretimYili = "2010";
            Araba araba2 = new Araba();
            araba2.Marka = "B";
            araba2.Model = "B1";
            araba2.Renk = "Siyah";
            araba2.UretimYili = "2020";
            Araba araba3 = new Araba();
            araba3.Marka = "C";
            araba3.Model = "C1";
            araba3.Renk = "Mavi";
            araba3.UretimYili = "2016";
            Araba araba4 = new Araba();
            araba4.Marka = "D";
            araba4.Model = "D1";
            araba4.Renk = "Metalik Gri";
            araba4.UretimYili = "2018";

            switch (listBox1.SelectedItem)
            {
                case "A - A1":
                    label1.Text = "Markasý: " + araba1.Marka + "\n" + "Modeli: " + araba1.Model + "\n" + "Rengi: " + araba1.Renk + "\n" + "Üretim Yýlý: " + araba1.UretimYili;
                    break;
                case "B - B1":
                    label1.Text = "Markasý: " + araba2.Marka + "\n" + "Modeli: " + araba2.Model + "\n" + "Rengi: " + araba2.Renk + "\n" + "Üretim Yýlý: " + araba2.UretimYili;
                    break;
                case "C - C1": 
                    label1.Text = "Markasý: " + araba3.Marka + "\n" + "Modeli: " + araba3.Model + "\n" + "Rengi: " + araba3.Renk + "\n" + "Üretim Yýlý: " + araba3.UretimYili;
                    break;
                case "D - D1":
                    label1.Text = "Markasý: " + araba4.Marka + "\n" + "Modeli: " + araba4.Model + "\n" + "Rengi: " + araba4.Renk + "\n" + "Üretim Yýlý: " + araba4.UretimYili;
                    break;
            }
        }
    }
}