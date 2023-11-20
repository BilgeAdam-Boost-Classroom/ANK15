using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3
{
    public partial class Form2 : Form
    {
        Form1 globalForm1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            globalForm1 = form1;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            cbxRenk.Items.Add("AliceBlue");
            cbxRenk.Items.Add("Red");
            cbxRenk.Items.Add("Green");
            cbxRenk.Items.Add("Blue");
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            switch (cbxRenk.SelectedItem)
            {
                case "AliceBlue":
                    globalForm1.BackColor = Color.AliceBlue;
                    break;
                case "Red":
                    globalForm1.BackColor = Color.Red;
                    break;
                case "Green":
                    globalForm1.BackColor = Color.Green;
                    break;
                case "Blue":
                    globalForm1.BackColor = Color.Blue;
                    break;
                default:
                    MessageBox.Show("Hatalı Seçim.");
                    break;
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
