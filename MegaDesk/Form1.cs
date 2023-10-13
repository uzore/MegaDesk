using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 closeForm1 = new Form1();
            closeForm1.Tag = this;
            closeForm1.Show(this);
            Close();
        }

        private void ViewQuote_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuote = new ViewAllQuotes();
            viewQuote.Tag = this;
            viewQuote.Show(this);
            Hide();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            Hide();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuotes viewAddQuotes = new AddQuotes();
            viewAddQuotes.Tag = this;
            viewAddQuotes.Show(this);
            Hide();
        }
    }
}
