using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transcript
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
            {
                gosterilecekForm.MdiParent = this;
            }
            foreach (Form altForm in MdiChildren)
            {
                if(gosterilecekForm.Text == altForm.Text)
                {
                    altForm.Show();
                }
                else
                {
                    altForm.Close();
                }
            }
        }

        private void OgrenciEkleSil_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciEkleSil());
        }

        private void DersEkleSil_Click(object sender, EventArgs e)
        {
            FormGoster(new DersEkle());
        }

        private void DonemEkleSil_Click(object sender, EventArgs e)
        {
            FormGoster(new DonemEkle());
        }

        private void OgrenciTranscript_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciTranscript());
        }

        private void OgrenciDersEkle_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciDersEkle());
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
