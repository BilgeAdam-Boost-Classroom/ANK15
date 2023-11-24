namespace EnumPersonel
{
    public partial class Form1 : Form
    {
        List<Calisan> calisanlar = new List<Calisan>();
        public Form1()
        {
            InitializeComponent();
            cbxDepartman.Items.Add("Se�iniz");
            
            cbxDepartman.SelectedIndex = 0;
        }

        private void cbxDepartman_MouseClick(object sender, MouseEventArgs e)
        {
            cbxDepartman.Items.Remove("Se�iniz");
            cbxDepartman.Items.Clear();
            cbxDepartman.Items.AddRange(Enum.GetNames(typeof(Bolum)));

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("L�tfen isim giriniz.");
                return;
            }
            if(cbxDepartman.Text == "" || cbxDepartman.Text == "Se�iniz")
            {
                MessageBox.Show("L�tfen se�im yap�n�z");
                return;
            }
            
            Calisan calisan = new Calisan();
            calisan.Ad = txtAd.Text;
            calisan.Bolum = (Bolum)Enum.Parse(typeof(Bolum), cbxDepartman.Text);
            calisanlar.Add(calisan);
            MessageBox.Show("Ki�i eklenmi�tir.");
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            lbxCalisanlar.Items.Clear();
            lbxCalisanlar.Items.AddRange(calisanlar.ToArray());
        }

        private void lbxCalisanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calisan seciliCalisan = (Calisan)lbxCalisanlar.SelectedItem;
            MessageBox.Show(seciliCalisan.Bolum.ToString());
        }
    }
}