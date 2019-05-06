using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson64imageviews
{
    public partial class Form1 : Form
    {
        private int currentIndex = 0;//variable used for storing position of image list, set equal to 0 at first because of the image list
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            imageList1.Images.Clear();//clear image list whenever a new year is chosen
            openFileDialog1.Multiselect = true;//this allows us to select multiple images
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                for(int i=0;i<openFileDialog1.FileNames.Length;i++)//needed to grab each image from the open file dialog array of images
                {
                    imageList1.Images.Add(Image.FromFile(openFileDialog1.FileNames[i]));//makes images from the images array the file dialog is providing
                }
                pictureBox1.Image = imageList1.Images[currentIndex];//make sure the picture box displays an image after the dialog box is closed
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            //make sure that you don't step beyond the last index of the
            //makes sure that some images have actually been added
            if(currentIndex!=imageList1.Images.Count-1 && imageList1.Images.Count>0)
            {
                pictureBox1.Image = imageList1.Images[++currentIndex];//first add 1 to the index and then display that new picture in the picture box
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentIndex != 0) //make sure the image index is not at 0
                pictureBox1.Image = imageList1.Images[--currentIndex];//decrease index by 1 and display that updated image to picture box 
        }
    }
}
