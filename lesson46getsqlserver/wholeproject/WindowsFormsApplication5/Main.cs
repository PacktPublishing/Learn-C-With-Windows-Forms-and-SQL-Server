using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void businessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BizContacts frm = new BizContacts();//make new business contacts form
            frm.MdiParent = this;//set the main form as the parent of each business form
            frm.Show();//show the new form
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);//cascade the child form inside the main form
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);//apply vertical layout to child forms inside parent form
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);//apply horizontal layout to child forms inside parent form
        }
    }
}
