using OkulExerciseWF;
using OkulExerciseWF.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteUygulama
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void ogrenciEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danışmanEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void danismanEkraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new DanismanForm());
        }

        private void ogrenciEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new OgrenciForm());
        }


        private void dersEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new DersForm());
        }

        private void ogrenciDersEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new OgrenciDersForm());
        }
    }
}
