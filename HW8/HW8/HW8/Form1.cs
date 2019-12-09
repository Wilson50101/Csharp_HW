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
namespace HW8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
          "AttachDbFilename=|DataDirectory|Database1.mdf;" +
          "Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            //建立Sqlconnection物件db
            SqlConnection db = new SqlConnection();
            //設定db連結本機SQL Server的Database1.mdf資料庫
            db.ConnectionString = cn;
            //建立DataAdapter物件da
            //da可查詢員工資料表所有紀錄
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM 書籍 ORDER BY 定價 DESC", db);
            //建立dataset物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //datagridview呈現的資料來源為ds內第一個datatable資料表(即Tables[0])
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText =
                  "INSERT INTO 書籍(書號,書名,作者,定價)VALUES(N'" +
                txtId.Text.Replace("'", "''") + "',N'" +
                txtName.Text.Replace("'", "''") + "',N'" +
                txtA.Text.Replace("'", "''") + "'," +
                txtPrice.Text + ")";
                cmd.ExecuteNonQuery();
                db.Close();
                Form1_Load(sender, e);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "UPDATE 書籍 SET 書名=N'" +
              txtName.Text.Replace("'", "''") + "'," +
                  "作者=N'" + txtA.Text.Replace("'", "''") + "'," +
                  "定價=" + txtPrice.Text + " WHERE 書號=N'" +
              txtId.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                Form1_Load(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "DELETE FROM 書籍 WHERE 書號=N'" +
             txtId.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                Form1_Load(sender, e);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
