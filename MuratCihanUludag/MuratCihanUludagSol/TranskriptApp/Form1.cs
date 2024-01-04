using TranskriptApp.Pages;

namespace TranskriptApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenForm(Form newForm)
        {
            newForm.StartPosition = 0;
            newForm.MdiParent = this;

            foreach (var item in MdiChildren)
            {
                if (newForm.Text == item.Text)
                {
                    item.Show();
                }
                else
                {
                    item.Close();
                }
            }

        }

        private void ogrenciIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Islemler islem = new Islemler();
            OpenForm(new Islemler());
        }



        private void dersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenForm(new DersEkleme());
        }
    }
}