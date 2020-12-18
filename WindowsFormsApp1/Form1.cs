using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int imagenum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // the image list was set in the form designer and named imageList1
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!imageList1.Images.Empty) { 
                pictureBox1.Image = imageList1.Images[imagenum];
                imagenum = (imagenum + 1) % imageList1.Images.Count;
                toolStripStatusLabel1.Text = imageList1.Images.Keys[imagenum].ToString();
            }
        }
    }
}

