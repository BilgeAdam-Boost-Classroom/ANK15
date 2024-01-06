using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANK15TRANSKRİPT
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciEkle());
        }

        private void dersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new DersEkle());
        }

        private void donemEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new DonemEkle());
        }

        private void ogrenciDersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciDersEkle());
        }

        private void transkriptGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new TranskriptGör());
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
    }
}
