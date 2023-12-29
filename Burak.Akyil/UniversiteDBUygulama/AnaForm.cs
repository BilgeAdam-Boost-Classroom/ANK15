using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteDBUygulama
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

        private void danismanEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new DanismanForm());
        }

        private void ogrenciEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new OgrenciForm());
        }
    }
}
