using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteEF1
{
    public partial class AnaForm : Form
    {
        public AnaForm()
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

        private void danısmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new Danisman());
        }

        private void ogrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new Ogrenci());
        }

        private void dersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new Ders());
        }

        private void diplomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new Diploma());
        }

        private void ogrenciyeDersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new OgrenciyeDers());
        }

        private void ogrenciyeDanısmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new OgrenciyeDanısman());
        }
    }
}
