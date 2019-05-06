using System;
using System.Windows.Forms;

namespace lesson11ifelsewithcheckboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Checked is a property of a box, this property is either true or false
            //true or false values are used with if/else blocks to make decisions
            if(checkBox1.Checked)
            {
                MessageBox.Show("Are you sure you want to get rich?");//runs when the box is checked
            }
            else
            {
                MessageBox.Show("Are you sure you don't want to get rich?");//runs when the box is not checked
            }
        }
    }
      
}
