using BurgerApp.Entity.Enums;
using BurgerApp.Entity.Solids;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BurgerApp
{
    public partial class SiparisEkle : Form
    {
        Menu selecetMenu;


        public SiparisEkle()
        {

            InitializeComponent();
            ComboBoxSetName();
            CreateMalzemeList();

        }

        #region FlowLayoutPanelTest
        //private void CreateEkstraMalzeme()
        //{
        //    int columns = 3;
        //    int currentColumn = 0;

        //    FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
        //    flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
        //    flowLayoutPanel.WrapContents = false;

        //    foreach (var item in ExtraMetarials.ExtraMalzemeler)
        //    {

        //        CheckBox checkBox = new CheckBox
        //        {
        //            Text = item.Key
        //        };

        //        flowLayoutPanel.Controls.Add(checkBox);
        //        currentColumn++;

        //        if (currentColumn == columns)
        //        {
        //            currentColumn = 0;
        //            flowLayoutPanel.SetFlowBreak(checkBox, true);
        //        }
        //    }
        //    groupBox2.Controls.Add(flowLayoutPanel);
        //} 
        #endregion

        #region ComboBoxMenu

        private void ComboBoxSetName()
        {
            comboBoxMenu.DisplayMember = "Name";
            comboBoxMenu.DataSource = MenuList.BurgerList;
            comboBoxMenu.SelectedIndex = 0;
        }
        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checkedListMalzeme.Items.Clear();

            selecetMenu = MenuList.BurgerList.FirstOrDefault(c => c.Name == comboBoxMenu.Text);

            for (int i = 0; i < checkedListMalzeme.Items.Count; i++)
            {
                bool isItemChecked = checkedListMalzeme.GetItemCheckState(i) == CheckState.Checked;
                if (isItemChecked)
                {
                    checkedListMalzeme.SetItemChecked(i, true);
                }
                else
                {
                    checkedListMalzeme.SetItemChecked(i, false);

                }
            }
        

            switch (selecetMenu.Size)
            {
                case MenuSize.small:
                    radioSmall.Checked = true;
                    break;
                case MenuSize.medium:
                    radioMid.Checked = true;
                    break;
                case MenuSize.king:
                    radioKing.Checked = true;
                    break;
            }

        }

        #endregion

        #region RadioBox_Metotlari

        private void IsCheckRadio(RadioButton radioButton, MenuSize size)
        {
            selecetMenu.Size = size;
            if (radioButton.Checked)
            {
                selecetMenu.MenuSizePluse(true);
            }
            else
            {
                selecetMenu.MenuSizePluse(false);
            }

        }

        private void radioSmall_CheckedChanged(object sender, EventArgs e)
        {
            IsCheckRadio(radioSmall, MenuSize.small);
        }

        private void radioMid_CheckedChanged(object sender, EventArgs e)
        {

            IsCheckRadio(radioMid, MenuSize.medium);
        }

        private void radioKing_CheckedChanged(object sender, EventArgs e)
        {


            IsCheckRadio(radioKing, MenuSize.king);
        }
        #endregion

        #region CheckListMalzeme
        private void CreateMalzemeList()
        {
            checkedListMalzeme.DisplayMember = "Value";
            checkedListMalzeme.ValueMember = "Key";
            checkedListMalzeme.DataSource = ExtraMetarials.ExtraMalzemeler.ToList();

        }
        #endregion



        private void checkedListMalzeme_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            KeyValuePair<string, double> keyValue = (KeyValuePair<string, double>)checkedListMalzeme.SelectedItem;
            selecetMenu = MenuList.BurgerList.FirstOrDefault(c => c.Name == comboBoxMenu.Text);
            if (e.NewValue == CheckState.Checked)
            {
                selecetMenu.ekstraMalzeme.Add(keyValue.Key, keyValue.Value);
                selecetMenu.MenuEkstraPriace(true, keyValue.Value);
            }
            else
            {
                selecetMenu.ekstraMalzeme.Remove(keyValue.Key);
                selecetMenu.MenuEkstraPriace(false, keyValue.Value);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selecetMenu = MenuList.BurgerList.FirstOrDefault(c => c.Name == comboBoxMenu.Text);
            listBox1.Items.Add(selecetMenu.ToString());

        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            selecetMenu = MenuList.BurgerList.FirstOrDefault(c => c.Name == comboBoxMenu.Text);
            selecetMenu.LastPriace();
            PriaceLabel.Text = selecetMenu.Priace.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            selecetMenu = MenuList.BurgerList.FirstOrDefault(c => c.Name == comboBoxMenu.Text);
            selecetMenu.Count = (int)numericUpDown1.Value;
        }
    }
}
