using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Araba araba1,araba2,araba3,araba4;
        private void Form1_Load(object sender, EventArgs e)
        {
            Araba araba1= new Araba();
            araba1.Marka = "A";
            araba1.Model = "A1";
            araba1.Renk = "Siyah";
            araba1.UretimYili = "2010";

            Araba araba2 = new Araba();
            araba2.Marka = "B";
            araba2.Model = "B1";
            araba2.Renk = "Siyah";
            araba2.UretimYili = "2020";

            Araba araba3 = new Araba();
            araba3.Marka = "C";
            araba3.Model = "C1";
            araba3.Renk = "Mavi";
            araba3.UretimYili = "2016";
            araba3.OzellikleriYaz();

            Araba araba4 = new Araba();
            araba4.Marka = "D";
            araba4.Model = "D1";
            araba4.Renk = "Metali Gri";
            araba4.UretimYili = "2018";

            listBox1.Items.Add(araba1.Marka + "-" + araba1.Model);
            listBox1.Items.Add(araba2.Marka + "-" + araba2.Model);
            listBox1.Items.Add(araba3.Marka + "-" + araba3.Model);
            listBox1.Items.Add(araba4.Marka + "-" + araba4.Model);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = araba1.OzellikleriYaz();
                    break;
                case 1:
                    label1.Text = araba2.OzellikleriYaz();
                    break;
                case 2:
                    label1.Text = araba3.OzellikleriYaz();
                  
                    break;
                case 3:
                    label1.Text = araba4.OzellikleriYaz();
           
                    break;
                default:
                    break;
            }
        }
    }
}
