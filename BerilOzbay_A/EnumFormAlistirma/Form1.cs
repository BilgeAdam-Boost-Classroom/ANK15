namespace EnumFormAlistirma
{
    public partial class Form1 : Form
    {
        List<Calisan> calisanlar = new List<Calisan>();
        public Form1()
        {
            InitializeComponent();

            cbDepartman.DataSource = Enum.GetValues(typeof(Bolum));
            cbDepartman.SelectedIndex = -1;
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
            calisan.AdSoyad = txtPersonel.Text;
            calisan.CalisanBolum = (Bolum)cbDepartman.SelectedValue;
            calisanlar.Add(calisan);
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            lbPersonelGoster.Items.Clear();
            foreach (var calisan in calisanlar)
            {
                lbPersonelGoster.Items.Add(calisan.AdSoyad + " " + calisan.CalisanBolum);
            }
        }
    }
}