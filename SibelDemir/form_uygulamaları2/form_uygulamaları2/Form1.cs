namespace form_uygulamaları2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici;
            string sifre;
            kullanici = txtKullanıcıAdı.Text;
            sifre = txtParola.Text;
            if (kullanici == "sibel" && sifre == "12345")
            {
                Form2 form = new Form2();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanici bilgileri yanlış!");
            }

        }
    }
}