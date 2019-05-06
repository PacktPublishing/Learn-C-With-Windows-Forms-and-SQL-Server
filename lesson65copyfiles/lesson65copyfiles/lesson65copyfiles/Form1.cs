using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//needed for file operations like copying

namespace lesson65copyfiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFiles_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)//check whether some files are selected
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)//loop to iterate through the array of file names
                    checkedListBox1.Items.Add(openFileDialog1.FileNames[i]);//line actually fills the list box 

                chkAll.Enabled = true;//after the list box is filled, enable the check all check box
            }

        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                lblPath.Text = folderBrowserDialog1.SelectedPath;//display path to user of program where files will go
                btnCopy.Enabled = true;//enable button to copy files
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;//restore the progress bar between copy operations
            progressBar1.Maximum = checkedListBox1.CheckedItems.Count;
            foreach(var item in checkedListBox1.CheckedItems)//needed to grab each item from the list
            {
                progressBar1.PerformStep();//update the progress
                //Path.GetFile gets the file name only
                //Path.Combine creates a new path where the file is saved
                //Copy operation is performed
                File.Copy(item.ToString(), Path.Combine(folderBrowserDialog1.SelectedPath, Path.GetFileName(item.ToString())),true);
            }

        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAll.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)//needed to grab each box inside the check list box
                    checkedListBox1.SetItemChecked(i, true);//check the box at index i
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)//needed to grab each box inside the check list box
                    checkedListBox1.SetItemChecked(i, false);//false value indicates each item in the box should be unchcked
            }
        }
    }
}
