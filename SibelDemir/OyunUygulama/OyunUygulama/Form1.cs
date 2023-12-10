namespace OyunUygulama
{
    public partial class Form1 : Form
    {
        public List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button>() { button1,button2,button3,button4,button5,button6,button7,button8,button9};
            foreach (var item in buttons)
            {
                item.Click +=
            }


        }

        
}