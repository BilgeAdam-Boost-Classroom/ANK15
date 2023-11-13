namespace WinFormExercises
{
    public partial class Answer1 : Form
    {
        public Answer1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Parse(txtA.Text);
            int b = Parse(txtB.Text);
            int c = Parse(txtC.Text);
            double x1, x2;

            int delta = (b * b) - (4 * a * c);

            if (a == 0)
            {
                lblsnc.Text = "a sýfýr olamaz.";
                return;
            }
            if (delta == 0)
            {
                x1 = -(b / (2 * a));
                lblsnc.Text = $"Çarpýþýk kök vardýr.{x1}";
            }
            else if (delta >= 0)
            {
                x1 = -((b + Math.Sqrt((delta)) / (2 * a)));
                x2 = -((b - Math.Sqrt((delta)) / (2 * a)));
                lblsnc.Text = $"Ýki kök vardýr. \nX1 : {Math.Round(x1, 2)} , X2 : {Math.Round(x2)}";
            }
            else
            {
                lblsnc.Text = "Reel kök yoktur.";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private int Parse(string text)
        {
            int number = 0;

            while (!int.TryParse(text, out number))
            {
                Console.WriteLine("Girilen deper yanlýþ.Tekrar deneyin.");
                Console.WriteLine("Deðer giriniz:");
                Console.WriteLine();

            }
            return number;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
