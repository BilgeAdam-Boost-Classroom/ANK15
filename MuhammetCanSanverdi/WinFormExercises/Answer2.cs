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
    public partial class Answer2 : Form
    {
        public Answer2()
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
            int[] numbers = new[] { Parse(txtnumber1.Text), Parse(txtnumber2.Text) };
            if (numbers[0] == numbers[1])
            {
                lblsnc.Text = "İki sayı eşit";
                return;
            }
            lblsnc.Text = $"Büyük sayı : {numbers.Max()} \n Küçük sayı : {numbers.Min()}";
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
