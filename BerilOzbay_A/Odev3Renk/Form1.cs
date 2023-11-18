namespace Odev3Renk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MyForm1 = this;
            form2.ShowDialog();
        }
    }
}