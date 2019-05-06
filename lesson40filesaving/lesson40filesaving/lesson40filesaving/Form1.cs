using System;
using System.Drawing;
using System.Windows.Forms;

namespace lesson40filesaving
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //code below allows us to save a file to the hard drive
            //file is saved in the location selected in the file save dialog
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);//runs and saves the file text to an actual file
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";//load dialog box with no filename in the text box
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);//load file from drive into rich text box
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);//shows the message from the exception object
                }
                
            }
        }

        private void toolStripTextBox2_DoubleClick(object sender, EventArgs e)
        {
            if(txtNew.Text!="") //make sure the second text box on menu is not empty
                richTextBox1.Text=richTextBox1.Text.Replace(txtOld.Text, txtNew.Text);      //replace
        }

        private void toolStripTextBox1_DoubleClick(object sender, EventArgs e)
        {
            if(txtOld.Text.Trim().Length>0)
            {
                int replaceFrom=richTextBox1.Find(txtOld.Text.Trim());
                richTextBox1.Select(replaceFrom, txtOld.Text.Trim().Length);
                richTextBox1.SelectionBackColor = Color.Yellow;
            }
                
        }
    }
}
