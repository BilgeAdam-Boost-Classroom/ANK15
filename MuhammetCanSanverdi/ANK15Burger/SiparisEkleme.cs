using ANK15Burger.Entity.Concrete;
using ANK15Burger.Entity.Concrete.Enum;
using ANK15Burger.Entity.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANK15Burger
{
    public partial class SiparisEkleme : Form
    {
        public SiparisEkleme()
        {
            InitializeComponent();
            MenuBoyutlarıGrubaYerlestir();
            cbxMenu.Items.AddRange(Field.Menuler.ToArray());
            chkListMalzeme.Items.AddRange(Field.EkstraMalzemeler.ToArray());
            cbxAdet.Items.AddRange(Field.Adetler.Select(a => (object)a).ToArray());


        }

        private void grpbxBoyut_Enter(object sender, EventArgs e)
        {

        }

        private void cbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuBoyutlarıGrubaYerlestir()
        {
            int i = 3;
            var boyutlar = Enum.GetNames(typeof(Boyut));
            foreach (var item in boyutlar)
            {
                grpbxBoyut.Controls.Add(new RadioButton()
                {
                    AutoSize = true,
                    Location = new Point(i, 19),
                    Name = "rdBtn" + item,
                    Size = new Size(94, 19),
                    TabIndex = 0,
                    TabStop = true,
                    Text = item,
                    UseVisualStyleBackColor = true
                });
                i += 100;
            }
        }

        private void chkListMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            decimal menuPrice=0;
            decimal sumPrice = lblPrice.Text != "" ? Convert.ToDecimal(lblPrice.Text) : 0;

            var selectedMenu = (Menu)(cbxMenu.SelectedItem);
            var selectedButton = grpbxBoyut.Controls.OfType<RadioButton>().FirstOrDefault(m => m.Checked).Text;
            var menu = new SiparisMenu()
            {
                Ad = ((Menu)(cbxMenu.SelectedItem)).Ad,
                Boyut = (Boyut)Enum.Parse(typeof(Boyut), selectedButton),
                EkstraMalzemeler = chkListMalzeme.CheckedItems.Cast<EkstraMalzeme>().ToList(),
                Fiyat = selectedMenu.Fiyat,
                Adet = (int)cbxAdet.SelectedItem
            };

            switch (menu.Boyut)
            {
                case Boyut.Küçük:
                    break;
                case Boyut.Orta:
                    menu.Fiyat *= 1.15m;
                    break;
                case Boyut.Büyük:
                    menu.Fiyat *= 1.25m;
                    break;
                default:
                    break;
            }

            menuPrice = menu.Fiyat * menu.Adet;
            menu.EkstraMalzemeler.ForEach(e =>  menuPrice += e.Fiyat);
            sumPrice += menuPrice;
            lblPrice.Text = sumPrice.ToString();
            lblCurrency.Text = RegionInfo.CurrentRegion.CurrencySymbol;
            menu.Fiyat = menuPrice;

            listBoxSiparisler.Items.Add(menu);
        }

        private void chkListMalzeme_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void SiparisEkleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Field.Siparisler.AddRange(listBoxSiparisler.Items.Cast<SiparisMenu>());
            MessageBox.Show("Sipariş eklendi");
        }
    }
}
