using Calisanlar.Models;
using System.Text.Json;

namespace Calisanlar
{
    public partial class Form1 : Form
    {
        List<Calisan> calisanlar = new List<Calisan>();
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
            calisan.Ad = textName.Text;
            calisan.Soyad = textSurname.Text;
            calisan.Yas = Convert.ToInt32(textAge.Text);
            calisan.Tc = Convert.ToInt64(textTc.Text);
            if (calisan.Tc != 11)
            {
                MessageBox.Show("Tc Numarsi 11 haneden kucuk olamaz!!");
                return;
            }
            foreach (var item in calisanlar)
            {
                if (item.Tc == calisan.Tc)
                {
                    MessageBox.Show("Ayni tc kimlikli biri var");
                    return;
                }
            }
            calisanlar.Add(calisan);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(calisanlar.ToArray()); 
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (count > calisanlar.Count)
            {
                return;
            }
       
            CalisanLabe();
        }

        private void btnIler_Click(object sender, EventArgs e)
        {
            if (calisanlar.Count > count + 1)
            {
                count++;
                CalisanLabe();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (calisanlar.Count >= count && count > 0)
            {
                count--;
                CalisanLabe();
            }
        }
        public void CalisanLabe()
        {
            fullLabel.Text = $"";
            fullLabel.Text = calisanlar[count].ToString();  
        }
    }
}