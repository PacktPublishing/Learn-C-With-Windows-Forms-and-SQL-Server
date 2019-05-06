using System;
using System.Linq;
using System.Windows.Forms;

namespace lesson37paramskeyword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            //input like 1,2,4:5,,6 works
            //input like 1,f,5,6 does not work because of the f
            //splits the text according to the list of separator, and removes blank spaces
            var values = textBox1.Text.Split(new char[] { ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            //line below converts each entry in the values array from a string to a decimal
            var valuesNumeric = Array.ConvertAll(values, decimal.Parse);
            //line below first finds the sum and then displays it to the user
            label1.Text = $"{valuesNumeric.Sum()}";
        }
    }
}
