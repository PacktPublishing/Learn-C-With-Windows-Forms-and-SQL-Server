using System;
using System.Windows.Forms;

namespace lesson25logicaloperator
{
    public partial class Form1 : Form
    {
        //convert the string "11/25/2016" into a date time object 
        //it's placed here so it happens only once
        DateTime dt = DateTime.Parse("11/25/2016");
        public Form1()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            //if somebody chooses a date earlier than 11/25/2016, display a discount message
            //if somebody chooses a date later than 11/25/2016, display a discount message
            //if somebody chooses the date itself, display no discount for your message
            //dateTimePicker1.Value.Date<dt means if chosen date is earlier in time than 11/25/2016
            //dateTimePicker1.Value.Date>dt means if chosen date is later in time than 11/25/2016
            //logical or operator || because it helps us make a decision 
            //|| returns true if the left side is true, or the right side is true, or perhaps both sides are true
            //if the left side is true, the right is not even checked, so the code is more efficient
            if (dateTimePicker1.Value.Date<dt || dateTimePicker1.Value.Date>dt)
            {
                label1.Text = "You qualify for a discount!"; //runs when if is true
            }
            else
            {
                label1.Text = "No discount for you!"; //runs when 11/25/2016 itself is selected
            }
        }
    }
}
