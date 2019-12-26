using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace NCKU_Eat
{
    public partial class AllRestaurant : Form
    {
        RestaurantEntities re = new RestaurantEntities();
        public AllRestaurant()
        {
            InitializeComponent();
        }

        private void AllRestaurant_Load(object sender, EventArgs e)
        {
            DGV_AllRestaurant.DataSource = re.餐廳.ToList();
        }
    }
}
