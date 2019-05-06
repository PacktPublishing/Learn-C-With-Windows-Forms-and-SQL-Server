using System;
using System.Windows.Forms;

namespace lesson15whileloops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";//clears the rich text box on each click
            //print 1,2,3,4,5
            //values begin at 1, values increase by 1, last value is 5
            //int is the data type like -10,0, 50, not 1.353
            int i = 1;//list begins at 1, so type int i=1
            //i will assume the values: 1,2,3,4,5
            //i<=5 because as loop runs, i=1, i=2,i=3,i=4,i=5
            //when i=6,6<=5, so the loop is skipped
            while(i<=5)
            {
                richTextBox1.Text += $"i={i}\n";
                i++;//this is needed to grow the value of i on each cycle of the loop
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";//this clears the text box on every click of the radio button
            //list the values 5,4,3,2,1
            //list starts at 5, goes down by 1, ends on 1
            int i = 5;//because the list starts at 5, set the value of i to 5
            //i=5, i=4,i=3,i=2,i=1, each of the previous makes the loop run
            //i=0, 0>=1 fails, so loop code does not run again
            while(i>=1)
            {
                richTextBox1.Text += $"i={i}\n";
                i--;//this has the effect of decreasing the value of i on each cycle of the loop
            }
        }
    }
}
