namespace Odev3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPass.Text == "1234")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Kullanýcý Adý veya Parola hatalý.");
            }
        }
    }
}