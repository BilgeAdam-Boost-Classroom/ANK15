namespace WinForms_23_11_2023
{
    public partial class Form1 : Form
    {
        List<Calisan> calisanList = new List<Calisan>();    
        public Form1()
        {
            InitializeComponent();


            var Durumlar = Enum.GetNames(typeof(Birimler));

            List<string> list = new List<string>() 
            {"Personel-1", "Personel-2", "Personel-3", "Personel-4", "Personel-5" };

            comboBoxCalisan.Items.AddRange(list.ToArray());
            comboBoxBirim.Items.AddRange(Durumlar);

            comboBoxBirim.SelectedIndex = 0;
            comboBoxCalisan.SelectedIndex = 0;
          


        }

        private void Save_Click(object sender, EventArgs e)
        {
            string name = comboBoxCalisan.SelectedItem.ToString();
            var birim_string = comboBoxBirim.SelectedItem.ToString();
            var birim = Enum.Parse(typeof(Birimler), birim_string); 
            Calisan calisan = new Calisan() {FullName= name , Birimler= (Birimler)birim };  
            calisanList.Add(calisan);
            listBox1.Items.Add(calisan.ToString());
        }

        private void show_Click(object sender, EventArgs e)
        {

            MessageBox.Show(calisanList[calisanList.Count-1].ToString());
        }
    }
}