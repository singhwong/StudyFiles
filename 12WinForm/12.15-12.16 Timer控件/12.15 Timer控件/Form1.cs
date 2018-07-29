using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _12._15_Timer控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"D:\Users\Walker\Documents\Visual Studio 2015\Projects\51zxwProjects\12.15 Timer控件\12.15 Timer控件\system.wav";

            if (DateTime.Now.Hour == 10 && DateTime.Now.Minute == 37 && DateTime.Now.Second == 0)
            {
                //sp.Play();//单次播放
                sp.PlayLooping();//循环播放
            }
            if (DateTime.Now.Hour == 10 && DateTime.Now.Minute == 37 && DateTime.Now.Second == 10)
            {
               
                sp.Stop();
            }

            //MessageBox.Show("关不掉了吧,我会不停地弹出","尝尝我的厉害");
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label2.Text = DateTime.Now.ToString();

        }
    }
}
