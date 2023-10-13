using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewQuote : Form
    {
        public ViewQuote()
        {
            InitializeComponent();
        }

        private void ViewQuote_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form1 viewMainMenu = new Form1();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }

        private void EditQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuotes editQuote = new AddQuotes();
            editQuote.Tag = this;
            editQuote.Show(this);
            Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Stream myStream;

            SaveFileDialog saveQuote = new SaveFileDialog();
            saveQuote.Filter = "txt files (*.txt) |*.txt|All files (*.*)|*.*";
            saveQuote.FilterIndex = 1;
            saveQuote.RestoreDirectory = true;

            if (saveQuote.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveQuote.OpenFile()) != null)
                {
                    myStream.Close();
                }
            }
        }
    }
}
