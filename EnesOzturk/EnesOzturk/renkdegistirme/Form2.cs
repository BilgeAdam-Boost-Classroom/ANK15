using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renkdegistirme
{
    public partial class Form2 : Form
    {
        Form1 form11;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            form11 = form1;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbxRenksecim.Items.Add("AliceBlue");
            cbxRenksecim.Items.Add("Red");
            cbxRenksecim.Items.Add("Green");
            cbxRenksecim.Items.Add("Blue");

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            switch (cbxRenksecim.SelectedItem)
            {
                case "AliceBlue":
                    form11.BackColor = Color.AliceBlue; break;
                case "Red":
                    form11.BackColor = Color.Red; break;
                case "Green":
                    form11.BackColor = Color.Green; break;
                case "Blue":
                    form11.BackColor = Color.Blue; break;

                default:
                    break;
            }
        }
    }
}
