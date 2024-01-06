namespace ANK15SAYIBUL
{
    public partial class Form1 : Form
    {
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            buttons = new() { button1, button2, button3, button3, button4, button5, button6, button7, button8, button9 };
            foreach (var item in buttonContainer.Controls)
            {
                ((Button)(item)).Click += Islem;
            };
        }

        private void Islem(object? sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
