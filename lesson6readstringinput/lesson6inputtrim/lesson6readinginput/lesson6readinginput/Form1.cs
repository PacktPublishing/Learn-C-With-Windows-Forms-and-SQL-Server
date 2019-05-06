using System;
using System.Windows.Forms;

namespace lesson6readinginput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //txtInput.Text means grab the text from the text box
            //txtInput.Text.ToLower() means convert the text value to lower case
            //equal sign saves it to the label text property
            //txtInput.Text.ToLower().Trim() trims aways blanks on both ends of the input
            //data type on the left matches data type from the last method on the right
            label1.Text = txtInput.Text.ToLower().Trim();
        }
    }
}
