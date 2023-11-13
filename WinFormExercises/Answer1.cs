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
                lblsnc.Text = "a s�f�r olamaz.";
                return;
            }
            if (delta == 0)
            {
                x1 = -(b / (2 * a));
                lblsnc.Text = $"�arp���k k�k vard�r.{x1}";
            }
            else if (delta >= 0)
            {
                x1 = -((b + Math.Sqrt((delta)) / (2 * a)));
                x2 = -((b - Math.Sqrt((delta)) / (2 * a)));
                lblsnc.Text = $"�ki k�k vard�r. \nX1 : {Math.Round(x1, 2)} , X2 : {Math.Round(x2)}";
            }
            else
            {
                lblsnc.Text = "Reel k�k yoktur.";
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
                Console.WriteLine("Girilen deper yanl��.Tekrar deneyin.");
                Console.WriteLine("De�er giriniz:");
                Console.WriteLine();

            }
            return number;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
