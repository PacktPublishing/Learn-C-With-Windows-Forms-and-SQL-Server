using System;
using System.Windows.Forms;

namespace lesson27methodpart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //as you move the marker, display a tool tip with the current value of the track bar
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //as you move the marker, display a tool tip with the current value of the track bar
            toolTip2.SetToolTip(trackBar2, trackBar2.Value.ToString());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch blocks are used to make decisions by allowing us to examine the different value of a variable
            //in this case, it's the index of the entry selected in the 
            switch(checkedListBox1.SelectedIndex)//use to examine selected index of entry in box
            {
                case 0: //case label that corresponds to first item selected, or Add
                    label1.Text = Add(trackBar1.Value,trackBar2.Value).ToString();//Call Add down below
                    break;
                case 1://examine whether the word Divide has been selected
                    label1.Text = Divide(trackBar1.Value,trackBar2.Value).ToString();//Call Divide down below
                    break;
            }
        }
        //private means accessible only in our code
        //static means we will be able to call our method just by typing its name
        //double is the type of data returned by the method
        //name of Method is Add
        //double x and double y are parameters
        //=> is called "expression bodied member" notation
        private static double Add(double x, double y) => x + y;

        private static double Divide(double x, double y)
        {
            //in math, division by 0 is not allowed: 5/0, for example, is not allowed
            //use ternary operator to handle division by 0 safely
            //if y is not 0, divide x by y and send that back to the calling code
            //if y is 0, return 0.0 to the calling code because division by 0 is not defined
            return (y != 0) ? x / y : 0.0;
        }
    }
}
