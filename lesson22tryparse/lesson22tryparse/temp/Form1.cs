using System;
using System.Windows.Forms;

namespace temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            DateTime date;//declare a variable to hold the input from the box after a conversion
            //read the value from the box, if conversion is successful, set the date variable 
            //save the date variable as a long date string
            //if conversion fails, save "Cannot convert" to dateFinal
            string dateFinal = DateTime.TryParse(textBox1.Text, out date) ? date.ToLongDateString() : date.ToLongDateString();
            label1.Text = dateFinal;//display message to user to let him or her know what's going one
        }
    }
}
