using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace StuScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt;
        BindingManagerBase bm;

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|TestDB.mdf;" +
                "Integrated Security=True";
            DataSet ds = new DataSet();

            SqlDataAdapter daScore = new SqlDataAdapter("SELECT * FROM 成績", cn);
            daScore.Fill(ds, "成績");

            txtId.DataBindings.Add("Text", ds, "成績.學號");
            txtName.DataBindings.Add("Text", ds, "成績.姓名");
            txtChi.DataBindings.Add("Text", ds, "成績.國文");
            txtEng.DataBindings.Add("Text", ds, "成績.英文");
            txtMath.DataBindings.Add("Text", ds, "成績.數學");
            txtSci.DataBindings.Add("Text", ds, "成績.自然");
            txtSoc.DataBindings.Add("Text", ds, "成績.社會");

            bm = this.BindingContext[ds, "成績"];
            dt = ds.Tables[0];
            hScrollBar1.SmallChange = 1;
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = bm.Count-1 ;
            lblCount.Text = (bm.Position+1).ToString ()  +" / "+ bm.Count.ToString ();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            bm.Position = hScrollBar1.Value;
            lblCount.Text = (bm.Position + 1).ToString() + " / " + bm.Count.ToString();
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtChi.Text = "";
            txtEng.Text = "";
            txtMath.Text = "";
            txtSci.Text = "";
            txtSoc.Text = "";
        }

        void Edit(string sqlstr)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|TestDB.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DataBindingsClear()
        {
            txtId.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtChi.DataBindings.Clear();
            txtEng.DataBindings.Clear();
            txtMath.DataBindings.Clear();
            txtSci.DataBindings.Clear();
            txtSoc.DataBindings.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Edit("INSERT INTO 成績(學號,姓名,國文,英文,數學,自然,社會,總分)VALUES('" +
                txtId.Text.Replace("'", "''") + "',N'" +
                txtName.Text.Replace("'", "''") + "'," +
                txtChi.Text + "," +
                txtEng.Text + "," +
                txtMath.Text + "," +
                txtSci.Text + "," +
                txtSoc.Text + "," +
                (int.Parse(txtChi.Text) + int.Parse(txtEng.Text) + int.Parse(txtMath.Text) + int.Parse(txtSci.Text) + int.Parse(txtSoc.Text)).ToString() + ")");
            DataBindingsClear();
            Form1_Load(sender, e);  
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Edit("UPDATE 成績 SET 姓名=N'" + txtName.Text.Replace ("'", "''") + 
                "',國文=" + txtChi.Text + 
                ",英文=" + txtEng.Text + 
                ",數學="+txtMath.Text +
                ",自然=" + txtSci.Text +
                ",社會=" + txtSoc.Text +
                ",總分=" + (int.Parse(txtChi.Text) + int.Parse(txtEng.Text) + int.Parse(txtMath.Text) + int.Parse(txtSci.Text) + int.Parse(txtSoc.Text)).ToString() +
                " WHERE 學號='" +txtId.Text.Replace("'", "''") + "'");
            DataBindingsClear();
            Form1_Load(sender, e);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Edit("DELETE FROM 成績 WHERE 學號='" +
                txtId.Text.Replace("'", "''") + "'");
            DataBindingsClear();
            Form1_Load(sender, e);
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void cbo_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_serachMax_Click(object sender, EventArgs e)
        {
            string str = "";
            switch (cbo_subject.Text)
            {
                case "國文":
                    var result0 = from r in dt.AsEnumerable()
                                 select new
                                 {
                                     國文 = r.Field<int>("國文")
                                 };
                    str = result0.Max(r => r.國文).ToString();
                    MessageBox.Show(str);
                    break;
                case "英文":
                    var result1 = from r in dt.AsEnumerable()
                                 select new
                                 {
                                     英文 = r.Field<int>("英文")
                                 };
                    str = result1.Max(r => r.英文).ToString();
                    MessageBox.Show(str);
                    break;
                case "數學":
                    var result2 = from r in dt.AsEnumerable()
                                 select new
                                 {
                                     數學 = r.Field<int>("數學")
                                 };
                    str = result2.Max(r => r.數學).ToString();
                    MessageBox.Show(str);
                    break;
                case "自然":
                    var result3 = from r in dt.AsEnumerable()
                                 select new
                                 {
                                     自然 = r.Field<int>("自然")
                                 };
                    str = result3.Max(r => r.自然).ToString();
                    MessageBox.Show(str);
                    break;
                case "社會":
                    var result4 = from r in dt.AsEnumerable()
                                 select new
                                 {
                                     社會 = r.Field<int>("社會")
                                 };
                    str = result4.Max(r => r.社會).ToString();
                    MessageBox.Show(str);
                    break;
                case "總分":
                    var result5 = from r in dt.AsEnumerable()
                                 select new
                                 {
                                     總分 = r.Field<int>("總分")
                                 };
                    str = result5.Max(r => r.總分).ToString();
                    MessageBox.Show(str);
                    break;

            }
        }
    }
}
