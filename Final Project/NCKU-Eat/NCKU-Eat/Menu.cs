using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKU_Eat
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_AllRestaurant_Click(object sender, EventArgs e)
        {
            AllRestaurant allRestaurant = new AllRestaurant();
            allRestaurant.Show();
        }
    }
}
