using System;//System is a name space. It stores EventArgs down below so our program can run. 
using System.Windows.Forms;//This is where Form object templates are stored so our program can run.

namespace lesson4onevariable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void msgLabel_Click(object sender, EventArgs e)
        {
            //imagine a cafe where the number of people changes over a period of time
            //Can there be -10 people? NO. 
            //0 a possible count for people? Yes.  
            //numbers like 0, 10 ,35 can be stored in a ushort
            //numbers like 14.533 cannot be stored in a ushort
            ushort numberPeople = 34;//tells number of people inside cafe
            //$ is used for string interpolation
            //variable names can be put directly into strings using string interpolation
            //\n has the effect of creating a new line so output is stacked vertically
            //{numberPeople} is read into the string and displayed on the label
            msgLabel.Text = $"Number of people : {numberPeople}\n";
            numberPeople = 23;//assign updated value based on some observation
            //line below displays updated value
            //+= has the effect of building a long string from smaller ones
            msgLabel.Text += $"Number of people : {numberPeople}";
        }
    }
}
