using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteDBFirst.Models
{
    public partial class Main : Form
    {
        public Main()
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

        private void danismanEkranİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new Danisman());
        }

        private void ogrenciEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new Ogrenci());
        }

        private void danismanOgrenciEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new OgrenciDanisman());
        }
    }
}
