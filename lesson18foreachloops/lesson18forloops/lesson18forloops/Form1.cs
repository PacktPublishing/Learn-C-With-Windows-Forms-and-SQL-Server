using System;
using System.Windows.Forms;

namespace lesson18forloops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblLetters.Text = "";//clear value of text property so output does not accumulate
            //123%46(*)A
            //grab each character, hold it and decide whether it's a letter or digit
            //grab 1, decide it's a number
            //grab A, examine it, decide it's a letter and display
            //for each character in the box text property
            foreach(var c in  textBox1.Text)
            {
                if (char.IsLetter(c))//check each character from the string to determine whether it's a letter
                    lblLetters.Text += $"{c}\n";//if a character is a letter, print it
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblNumbers.Text = "";//clear value of text so output does not accumulate between runs
            //grab each letter in the string inside the text box
            //12$5GA imagine this is the string, so as the loop runs, c is 1,2,$,5,G,A
            foreach (var c in textBox1.Text)
            {
                if (char.IsDigit(c))//examine each character to check whether it's a digit
                    lblNumbers.Text += $"{c}\n";//print the character if it's a digit
            }
        }
    }
}
