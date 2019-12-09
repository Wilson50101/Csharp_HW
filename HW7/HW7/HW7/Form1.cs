using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace HW7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void readTxt_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("CsharpHW7.txt");
            String data;
            do
            {
                data = sr.ReadLine();
                if (data == null)
                    break;
                TxtShow.Text += data + "\r\n";
            }
            while (true);
        }

        private void keymanually_Click(object sender, EventArgs e)
        {
            TxtShow.ReadOnly = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            TxtShow.Clear();
        }

        private void fontcolor_Click(object sender, EventArgs e)
        {

        }

        private void 黑色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtShow.ReadOnly = false;
            TxtShow.ForeColor = Color.Black;
            TxtShow.Text = TxtShow.Text;
        }

        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtShow.ReadOnly = false;
            TxtShow.ForeColor = Color.Red;
            TxtShow.Text = TxtShow.Text;
        }

        private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtShow.ReadOnly = false;
            TxtShow.ForeColor = Color.Green;
            TxtShow.Text = TxtShow.Text;
        }

        private void 藍色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtShow.ReadOnly = false;
            TxtShow.ForeColor = Color.Blue;
            TxtShow.Text = TxtShow.Text;
        }

        private void newfontsize_Click(object sender, EventArgs e)
        {

        }

        private void fontsizechange_Click(object sender, EventArgs e)
        {
            try
            {
                float newsize = float.Parse(newfontsize.Text);
                TxtShow.Font = new Font("新細明體", newsize);
            }
            catch
            {
                MessageBox.Show("請輸入數值!", "錯誤", MessageBoxButtons.OK);
            }

        }
    }
}
