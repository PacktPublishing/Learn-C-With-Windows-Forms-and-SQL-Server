using System;
using System.Windows.Forms;

namespace lesson20ternaryoperator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAmount_DoubleClick(object sender, EventArgs e)
        {
            //1. get text from box, convert to decimal , display formatted as currency
            //txtAmount.Text gets the text as a string
            //decimal.Parse(txtAmount.Text) feeds the string into Parse so it can, if possible, produce a number
            //:C formats the result as currency for display purposes
            lblAmountFormatted.Text = $"Amount:{decimal.Parse(txtAmount.Text):C}";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //in the combobox entry 1 is at index 0, entry 2 is at index 1
            decimal amount = decimal.Parse(txtAmount.Text);//read value from box and save in decimal form
            //ternary operator is the replace if/else blocks
            //check some logical condition: <, <=, ==, 5<4
            //runs code when the condition is true
            //runs some other code when the condition is false
            //condtion?run if true : run if false
            decimal finalAmount = (comboBox1.SelectedIndex == 0) ? amount * 0.9M : amount * 1.1M;
            lblFinalAmount.Text = $"Final Amount:{finalAmount:C}";
        }
    }
}
