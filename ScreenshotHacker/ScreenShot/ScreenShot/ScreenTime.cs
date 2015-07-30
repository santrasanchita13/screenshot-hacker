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
    public partial class ScreenTime : Form
    {
        public ScreenTime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog SF = new SaveFileDialog();

            SF.Filter = "Image File | *.PNG";

            SF.FileName = "";

            if(SF.ShowDialog() == DialogResult.OK)
            {
                Form1.BM.Save(SF.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if (comboBox1.Text == "")
            {
                MessageBox.Show("Set a Time First ", "Set a Time ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                timer1.Interval = int.Parse(comboBox1.Text) * 1000;
                timer1.Enabled = true;
            }
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                counter = counter + 1;
                // GetScreenShot(counter);
                // email.Send("screenshot"+counter+".jpeg");
                // MessageBox.Show("DONE");
                ScreenShotTime();

                
                this.pictureBox1.Image = Form1.BM;
                this.pictureBox1.Image.Save(@"C:\Users\Sabya\img" + counter + ".jpg");
                timer1.Enabled = true;
            }
            catch (Exception e1)
            {
            }

        }
       /*private static void GetScreenShot(int counter)
{
    using(Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, 
                                          Screen.PrimaryScreen.Bounds.Height))
   {
      using(Graphics graphics = Graphics.FromImage(bitmap as Image))
      {
         graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
      }
      bitmap.Save("screenshot"+counter+".jpeg",);       
   }
}*/
       static void ScreenShotTime()
        {
            try
            {
                Graphics GH = Graphics.FromImage(Form1.BM as Image);

                GH.CopyFromScreen(0, 0, 0, 0, Form1.BM.Size);
            }
            catch (Exception e)
            { 
            }
            
             //ScreenpictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        

        private void ScreenTime_Load(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        }
    }
