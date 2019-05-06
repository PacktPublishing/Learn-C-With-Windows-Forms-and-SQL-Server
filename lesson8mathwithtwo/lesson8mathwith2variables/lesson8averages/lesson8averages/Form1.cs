using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson8averages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add values, divide by 2
            //(2+5)/2
            //first read the values, convert to numerical, produce average
            //read text, convert to numerical form and save to the variables
            decimal firstValue = decimal.Parse(textBox1.Text);
            decimal secondValue = decimal.Parse(textBox2.Text);
            //average is called a computed variable
            //operand operator operand
            //first add the values, divide by 2, and save to average values
            decimal average = (firstValue + secondValue) / 2;
            //:C has the effect of formatting average value as currency
            label1.Text = $"Average Salary:{average:C}";
        }
    }
}
