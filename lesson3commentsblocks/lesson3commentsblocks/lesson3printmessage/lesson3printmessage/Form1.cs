using System;
using System.Windows.Forms;

namespace lesson3printmessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this code loads when the form first loads
            //msgLabel is the name of our label object
            //msgLabel.Text will allow us to set the text property of the label
            //= is the assignment operator that saves "hello, world" to the text property of the label
            //"Hello, World" is a string because it's characters between double quotes
            //; terminates the statement, without ;, the code will not work
            msgLabel.Text = "Hello, World!";

        }
    }
}
