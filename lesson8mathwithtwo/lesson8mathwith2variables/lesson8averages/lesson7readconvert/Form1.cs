using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson7readconvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //"10" as a string can be converted into a numerical version without double quotes: 10
            //if input is in the form "ten", this will crash the application
            //double.Parse(textBox1.Text): grab the text and convert, if possible
            // to numerical form for processing
            double input = double.Parse(textBox1.Text);
            //to display 10% of the input, write 0.1*input
            //input of 10, 0.1*10=1
            //input of 100, 0.1*100=10
            label1.Text = $"10% of {input} is {0.1*input}";
        }
    }
}
