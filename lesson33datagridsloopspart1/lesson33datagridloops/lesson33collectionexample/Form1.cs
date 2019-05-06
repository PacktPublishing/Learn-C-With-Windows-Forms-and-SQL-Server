using System;
using System.Windows.Forms;

namespace lesson33collectionexample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //4=2+2=3+1=6-2
        private void button1_Click(object sender, EventArgs e)
        {
            //this variable will hold the sum of the entries in the table
            //begins at 0 so the value of the sum at the end is correct
            double sum = 0;
            double value;//this variable will be used in attempts to convert the input to numerical form
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                //dataGridView1[0,i] is written this so we can step over the rows in the first column
                //0 is the index of the column
                //i is a variable that stands for the index of each row as we loop
                sum += double.TryParse(dataGridView1[0, i].Value.ToString(), out value)? value :0.0;
            }
            label1.Text = $"{sum}";//after loop runs, display the sum to the user
        }
    }
}
