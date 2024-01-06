namespace ANK15Burger
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void FormGoster(Form gosterilecekForm)
        {
            gosterilecekForm.StartPosition = 0;

            if (!MdiChildren.Contains(gosterilecekForm))
                gosterilecekForm.MdiParent = this;

            foreach (var altForm in MdiChildren)
            {
                if (gosterilecekForm.Text == altForm.Text)
                {
                    altForm.Show();
                }
                else
                {
                    altForm.Close();
                }
            }
        }

        private void siparisEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisEkleme());
        }

        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisBilgileri());
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new MenuEkleme());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new EkstraMalzemeEkleme());
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void siparisYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
