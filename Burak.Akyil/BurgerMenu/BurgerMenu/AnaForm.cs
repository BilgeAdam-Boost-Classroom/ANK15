using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerMenu
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

        private void SiparisEkle_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisEkleme());
        }

        private void SiparisBilgileri_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisBilgileri());
        }

        private void MenuEkle_Click(object sender, EventArgs e)
        {
            FormGoster(new MenuEkleme());
        }

        private void EkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            FormGoster(new EkstraMalzemeEkleme());
        }
    }
}
