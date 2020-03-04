using System;
using System.Globalization;
using System.Windows.Forms;

namespace Greeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGreet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There's always money in the banana stand!");
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            CultureInfo cultureGB = new CultureInfo("en-GB");

            textBoxDate.Text = DateTime.Now.ToString(cultureGB);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit application", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
