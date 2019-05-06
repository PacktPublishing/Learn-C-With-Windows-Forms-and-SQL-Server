using System;
using System.Windows.Forms;

namespace lesson11ifelseblocks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //textBox1.text has the text we want to find
            //Contains is a method that looks for something inside a string
            //result of using Contains is a true or false value, so it can be used with if/else blocks
            //if the big string contains the little string, then take an action
            //like displaying a simple message that says "..has been found"
            //if the big string does not contain the little string, take an action
            //like displaying a message that the text "..has not been found"
            if(textBox2.Text.Contains(textBox1.Text))
            {
                label2.Text = $"{textBox1.Text} has been found.";
            }
            else
            {
                label2.Text = $"{textBox1.Text} has not been found.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
