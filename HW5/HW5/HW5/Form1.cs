using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5
{
    public partial class form_compound_sum : Form
    {
        public form_compound_sum()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LblCompound_Sum_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int Principal = int.Parse(TxtPrincipal.Text);
            double Interest = double.Parse(TxtInterest.Text)/100;
            int Year = int.Parse(TxtYear.Text);
            if(Principal<=0||Interest<=0||Year<=0)
                MessageBox.Show("輸入錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
                MessageBox.Show("本利和(取整數)="+ (int)compound_sum(Principal, Interest, Year), "本利和", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private static double compound_sum(int principal, double interest, int year)
        {
            if (year > 0)
                return (1.0 + interest) * compound_sum(principal, interest, year - 1);
            else
                return principal;
        }

        private void form_compound_sum_Load(object sender, EventArgs e)
        {

        }
    }
}
