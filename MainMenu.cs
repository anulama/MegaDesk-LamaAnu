using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_LamaAnu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addQuotes = new AddQuotes(this);
            addQuotes.Tag = this;
            addQuotes.Show();

            // hide main menu
            this.Hide();
        }

        private void displayQuotes_Click(object sender, EventArgs e)
        {
            var DisplayQuotes = new DisplayQuotes(this);
            DisplayQuotes.Show();

            // hide main menu
            this.Hide();
        }

        private void viewAllQuotes_Click(object sender, EventArgs e)
        {
            var ViewAllQuotes = new ViewAllQuotes(this);
            ViewAllQuotes.Show();

            // hide main menu
            this.Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            var searchQuotes = new SearchQuotes(this);
            searchQuotes.Show();

            // hide main menu
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
