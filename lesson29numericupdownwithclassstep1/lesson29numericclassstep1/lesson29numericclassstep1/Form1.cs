using System;
using System.Windows.Forms;

namespace lesson29numericclassstep1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nmrFirstNumber_ValueChanged(object sender, EventArgs e)
        {
            //This has the effect of calling the Add method, stored inside the MathMethods class
            //Add is a method that is called by typing MathMethods.Add(value 1, value 2)
            //you can think of this code here as the calling code
            lblSum.Text = $"Sum={MathMethods.Add(nmrFirstNumber.Value, nmrSecondNumber.Value)}";
        }

        private void nmrSecondNumber_ValueChanged(object sender, EventArgs e)
        {
            //This has the effect of calling the Add method, stored inside the MathMethods class
            //Add is a method that is called by typing MathMethods.Add(value 1, value 2)
            //you can think of this code here as the calling code
            lblSum.Text = $"Sum={MathMethods.Add(nmrFirstNumber.Value, nmrSecondNumber.Value)}";
        }
    }
}
