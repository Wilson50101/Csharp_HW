using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW6_P76081108
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 0;

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TmrRun.Enabled = true;
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            TmrRun.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n == 0)
            {
                picCycle.Left += 10;
                if (picCycle.Left >= 450)
                {
                    picCycle.Image = ImgCycle.Images[++n];
                    picCycle.Left = 450;
                }  
            }
            if (n == 1)
            {
                picCycle.Top -= 10;
                if (picCycle.Top <= 0)
                {
                    picCycle.Image = ImgCycle.Images[++n];
                    picCycle.Left = 450;
                }
            }
            if (n == 2)
            {
                picCycle.Left -= 10;
                if (picCycle.Left <= 0)
                {
                    picCycle.Image = ImgCycle.Images[++n];
                    picCycle.Left = 0;
                }
            }
            if (n == 3)
            {
                picCycle.Top += 10;
                if (picCycle.Top >= 360)
                {
                    n = 0;
                    picCycle.Image = ImgCycle.Images[n];
                    picCycle.Top=360;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picCycle.Image = ImgCycle.Images[n];
        }

       
    }
}
