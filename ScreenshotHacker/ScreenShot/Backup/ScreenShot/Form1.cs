using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ScreenShot
{
    public partial class Form1 : Form
    {
        public static Bitmap BM = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        public Form1()
        {
            InitializeComponent();
            this.Text = "Screenshot developed by: Project X Group ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics GH = Graphics.FromImage(BM as Image);
            GH.CopyFromScreen(0, 0, 0, 0, BM.Size);

           ScreenShot_image SI = new ScreenShot_image();

           SI.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Programm is For ScreenShot Taking \n  Created by : Project X group ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.label1.Text = "Capture an Image";
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.label1.Text = "Capture an Image by specific  time";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.label1.Text = "About";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            this.label1.Text = "Exit";
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    button1_Click(sender, e);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            ScreenTime ST = new ScreenTime();

            ST.ShowDialog();
        
        }

       

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

       
    }
}
