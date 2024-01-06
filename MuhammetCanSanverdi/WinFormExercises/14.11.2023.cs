using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExercises
{
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }

        private void _14_Load(object sender, EventArgs e)
        {

        }

        private void listbxDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Listbox'tan seçilen eleman : " + listbxDersler.SelectedItem);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxDers.Items.Add(txtDers.Text);
            listbxDersler.Items.Add(txtDers.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbxDers.SelectedIndex = -1;
            listbxDersler.SelectedIndex = -1;
        }
    }
}
