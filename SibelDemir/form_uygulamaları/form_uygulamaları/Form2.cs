using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace form_uygulamaları
{
    public partial class Form2 : Form
    {
        Form1 globalForm1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            globalForm1 = form1;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem)
            {
                case "AliceBlue":
                    globalForm1.BackColor = Color.AliceBlue;
                    break;
                case "Red":
                    globalForm1.BackColor = Color.Red;
                    break;
                case "Blue":
                    globalForm1.BackColor = Color.Blue;
                    break;
                case "Green":
                    globalForm1.BackColor = Color.Green;
                    break;
                default:
                    break;
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
