namespace FabrikaCodeFirst
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void FormAc(Form gosterilecekForm)
        {
            gosterilecekForm.StartPosition = 0;
            if (!MdiChildren.Contains(gosterilecekForm))
                gosterilecekForm.MdiParent = this;
            foreach (var form in MdiChildren)
            {
                if (form.Text == gosterilecekForm.Text)
                    form.Show();
                else
                    form.Close();
            }
        }
        private void plakaEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new PlakaEkrani());
        }

        private void arabaEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new ArabaEkrani());
        }

        private void kiþiEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new KisiEkrani());
        }

        private void muhendisEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new MuhendisEkrani());
        }

        private void arabaMuhendisEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new MuhendisArabaEkrani());
        }
    }
}