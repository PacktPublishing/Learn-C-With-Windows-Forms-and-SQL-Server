using System;
using System.Linq;
using System.Windows.Forms;

namespace lesson38lingpart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "";//clear bottom box of text
            //line below is used to separate the text by different characters
            var words = richTextBox1.Text.Split(new char[] { ' ', ',', '.','!' });
            //grab each word, check whether it's 5 or more in length, and keep track of the count
            var count = words.Count(word => word.Length >= 5);
            //line below shows count of words 5 or more characters in length
            richTextBox2.Text = $"Number of words 5 or more chars:{count}";

            richTextBox2.Text += "\nWords 5 or more chars. sorted:";
            //line below picks out words that are 5 or more chars, turns the result into a list and saves to 
            //longWords
            var longWords = words.Where(word => word.Length >= 5).ToList();
            //line below orders the words from shorted to longest
            var longWordsSorted = longWords.OrderBy(word => word.Length).ToList();
            //grab each word from the longWordsSorted list, and display it to the rich text box on the bottom
            longWordsSorted.ForEach(word => richTextBox2.Text += $"\n{word}");
          
        }
    }
}
