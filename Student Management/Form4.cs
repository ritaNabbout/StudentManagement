using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 home = new Form1();
            
        }

        private void photo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            photo1 p = new photo1();
            p.MdiParent = this;
            p.Show();
        }

        private void photo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            photo2 p = new photo2();
            p.MdiParent = this;
            p.Show();
        }

        private void photo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            photo3 p = new photo3();
            p.MdiParent = this;
            p.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
