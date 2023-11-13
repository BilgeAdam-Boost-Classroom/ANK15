using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExercises
{
    public partial class Answer3 : Form
    {
        public Answer3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtnumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int number1, number2;
            int result = 1;
            number1 = Parse(txtnumber1.Text);
            number2 = Parse(txtnumber2.Text);

            for (int i = 1; i <= number2; i++)
            {
                result *= number1;
            }

            lblsnc.Text = result.ToString();
        }
        private int Parse(string text)
        {

            int number = 0;

            while (!int.TryParse(text, out number))
            {
                Console.WriteLine("Girilen deper yanlış.Tekrar deneyin.");
                Console.WriteLine("Değer giriniz:");
                Console.WriteLine();

            }
            return number;
        }

        private void Answer2_Load(object sender, EventArgs e)
        {

        }
    }
}
