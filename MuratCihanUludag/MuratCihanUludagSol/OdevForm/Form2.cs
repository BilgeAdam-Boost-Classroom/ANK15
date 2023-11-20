using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevForm
{
    public partial class Form2 : Form
    {
        string colorName;
        public Form2()
        {
            InitializeComponent();
            colorCombo.Items.Add("AliceBlue");
            colorCombo.Items.Add("Red");
            colorCombo.Items.Add("Green");
            colorCombo.Items.Add("Blue");
        }

        private void success_Click(object sender, EventArgs e)
        {
            ChangeColorBg(colorName);
        }
        public void ChangeColorBg(string color)
        {
            this.BackColor = Color.FromName(color);
        }

        private void colorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (colorCombo.SelectedItem)
            {
                case "AliceBlue":
                    colorName = "AliceBlue";
                    break;
                case "Red":
                    colorName = "Red";
                    break;
                case "Green":
                    colorName = "Green";
                    break;
                case "Blue":
                    colorName = "Blue";
                    break;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            colorName = "Control";
            ChangeColorBg(colorName);
        }
    }
}
