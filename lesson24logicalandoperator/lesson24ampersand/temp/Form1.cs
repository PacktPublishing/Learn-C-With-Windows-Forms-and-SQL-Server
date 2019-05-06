using System;
using System.Windows.Forms;

namespace temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //if both conditions on both sides of the && are true, the code immediately following the if runs
            //the logical && short circuits, so if the left side is false, the right side is not checked 
            // and the code immediately following the if is skipped
            if(chkExercise.Checked && chkDiet.Checked)//checks if both boxes are checked
            {
                lblResults.Text = "10% discount!"; //runs when both boxes are checked
            }
            else if(chkExercise.Checked)//checks if only the exercise box is checked
            {
                lblResults.Text = "4% discount!";//runs when only the exercise box is checked
            }
            else if(chkDiet.Checked)//checks if only the diet box is checked
            {
                lblResults.Text = "6% discount!";//runs when only the diet box is checked
            }
            else
            {
                lblResults.Text = "";//runs when neither box is checked, that is, when both boxes are unchecked
            }
        }
    }
}
