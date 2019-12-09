using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW05_02
{
    public partial class FormLogin : Form
    {
        public struct UserRec               //宣告UserRec結構，內含三個成員
        {
            public string passwd;           //密碼(passwd)
            public string email;            //email成員皆為string型別
            public bool sex;                //性別(sex)成員為bool型別
        }
        UserRec rec;               // 建立UserRec結構型別的變數rec
                                   // 建立Dictionary類別物件
        Dictionary<string, UserRec> userDict = new Dictionary<string, UserRec>();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {


            rec.passwd = "123456";         // 指派結構變數rec成員資料
            rec.sex = true;
            rec.email = "cc@yljh.edu.tw";
            userDict.Add("張三榮", rec);    // 加入第一筆資料到userDict物件中
                                         // ------------------------------------------------------------------------------
            rec.passwd = "111111";
            rec.sex = false;
            rec.email = "mm@hinet.net";
            userDict.Add("李玲玲", rec);    // 加入第二筆資料到userDict物件中
            TxtUserPW.PasswordChar = '*';
            if (!userDict.ContainsKey("林大山"))
            {
                rec.passwd = "224488";
                rec.sex = true;
                rec.email = "llyy@gmail.com";
                userDict.Add("林大山", rec);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string name = TxtUser_Name.Text;        // 登入使用者姓名
            string pw = TxtUserPW.Text;             // 登入使用者密碼
            string sexual;                          // 登入使用者性別
            string mail;                            // 登入使用者email
            if (!userDict.ContainsKey(name))        // 若userDict物件索引鍵不包含該姓名
                MessageBox.Show("使用者姓名輸入錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else                          // 若userDict物件索引鍵包含該姓名
            {
                if (userDict[name].passwd == pw)   // 若使用者密碼相符，顯示資料
                {
                    if (userDict[name].sex)
                        sexual = "男";
                    else
                        sexual = "女";
                    mail = userDict[name].email;
                    MessageBox.Show("顯示" + name + "相關資料\n" + "性別:" + sexual + "\n" + "Email:" + mail, "使用者資訊", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MessageBox.Show("列出所有使用者相關資料\n", "使用者資訊", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    int i = 0;
                    string[] strAry=new string[userDict.Count+2];
                    strAry[i++] = "列出所有使用者相關資料";
                    strAry[i++] = "姓名\t性別\t密碼\tmail";
                    foreach (KeyValuePair<string, UserRec> kv in userDict)
                    {
                        name = kv.Key;
                        if (kv.Value.sex)
                            sexual = "男";
                        else
                            sexual = "女";
                        pw = kv.Value.passwd;
                        mail = kv.Value.email;
                        strAry[i++]=name + "\t" + sexual + "\t" + pw + "\t" + mail;
                    }
                    TxtAllUserData.Lines = strAry;
                }
                else                                 // 若使用者密碼不符
                    MessageBox.Show("使用者密碼輸入錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void LblUserPW_Click(object sender, EventArgs e)
        {

        }
    }
}
