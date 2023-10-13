using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Schema;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuotes : Form
    {
        public AddQuotes()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Form1 viewMainMenu = new Form1();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayQuoteButton_Click(object sender, EventArgs e)
        {
            ViewQuote viewQuote = new ViewQuote();
            viewQuote.Tag = this;
            viewQuote.Show(this);
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Data Collation.
            string CustomerName = CustomerNameBox.Text;
            string Address = AddressBox.Text;
            string Width = WidthBox.Text;
            string Depth = DepthBox.Text;
            string Drawers = DrawerBox.SelectedItem.ToString();
            string MaterialList = MaterialListBox.SelectedItem.ToString();
            string RushOrder = RushBox.SelectedItem.ToString();

        }


        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MaterialListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WidthBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
