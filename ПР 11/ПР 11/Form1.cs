using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР_11
{
    public partial class Form1 : Form
    {
        private Bitmap[] Frames;
        private int FrameNum = 0;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frames = new Bitmap[18];
            for(int i = 0;i< 18;i++)
            {
                Frames[i] = new Bitmap(@"C:\Users\студент\Desktop\Практические\ПР 11\ПР 11\FramePic\Frame" + i + ".png");
                pictureBox1.Image = Frames[FrameNum];
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format("ТВОЯ СКОРОСТЬ: {0}", trackBar1.Value);
            trackBar1.Scroll += trackBar1_Scroll;
                for (int i = 0; i == trackBar1.Value; i++)
                {
                    if (i != 0)
                    {
                        int i1 = 1000 - i * 100;
                        timer1.Interval = i1;
                    }
                    else if (i == 0) { timer1.Stop(); }
                }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            FrameNum = ++FrameNum % Frames.Length;
            pictureBox1.Image = Frames[FrameNum];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled) button1.Text = "стоп";
            else button1.Text= "старт";
        }
    }
}
