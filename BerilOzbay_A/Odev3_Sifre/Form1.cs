namespace Odev3_Sifre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(tbAd.Text == "admin" && tbSifre.Text == "1234")
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanici Adi veya Parola hatali.");
            }
        }
    }
}