using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenShot
{
    public partial class ScreenShot_image : Form
    {
        public ScreenShot_image()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureBox1.Image = Form1.BM;
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Image File | *.PNG";
            SFD.FileName = "";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                Form1.BM.Save(SFD.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
   
        }

        private void ScreenShot_image_Load(object sender, EventArgs e)
        {

        }

        private void ScreenShot_image_Load_1(object sender, EventArgs e)
        {

        }
    }
}
