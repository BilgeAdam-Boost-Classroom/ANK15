namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCbx = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedCbx+"Comboboxtan Secildi.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedList = listBox1.SelectedItems[0].ToString();
            MessageBox.Show(selectedList+"Listboxtan Secildi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sclass = textBox1.Text;
            list.Add(sclass);
            Show();
        }
        void Show()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list.ToArray());
            listBox1.DataSource = null;
            listBox1.DataSource= list.ToArray();  

        }
    }
}
