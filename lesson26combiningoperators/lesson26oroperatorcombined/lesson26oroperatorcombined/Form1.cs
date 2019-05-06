using System;
using System.Windows.Forms;

namespace lesson26oroperatorcombined
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindVowels_Click(object sender, EventArgs e)
        {
            rchVowelsBox.Text = "";//clears box on each button click so output does not grow
            string text = rchInputBox.Text.ToLower();//grab the text, convert to lower case and save to variable named text
            //in English, the basic vowels are : a, e,i,o,u
            //grab each character, compare it against a,e,i,o, u to see whether it's a vowel
            foreach(char c in text)//needed to grab each character and store it in c for each cycle of the loop
            {
                //check whether the character that c represents on each cycle happens to be one of the vowels
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    rchVowelsBox.Text += $"{c}\n";
            }
        }
    }
}
