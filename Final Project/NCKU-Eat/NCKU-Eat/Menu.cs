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
    public partial class Menu : Form
    {
        //資工系館的經緯度
        PointF PositionCSIE = new PointF(22.996992f, 120.221510f);
        //建立RetaurantEntities物件,此物件可以管理Restaurant.mdf資料庫
        RestaurantEntities re = new RestaurantEntities();
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
