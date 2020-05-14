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
using System.Text.RegularExpressions;
namespace 三国杀
{
    public partial class QQSearch : Form
    {
        public QQSearch()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.txtwhere.Text != "")
            {
                MessageBox.Show("1");
                show();
            }
            else {
                MessageBox.Show("请输入要查询的条件!");
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
        }



        #region 添加好友弹窗信息传递
        public int imagenum0;
        public string Name0;
        public string Qm0;

        public int imagenum1;
        public string Name1;
        public string Qm1;

        public int imagenum2;
        public string Name2;
        public string Qm2;

        public int imagenum3;
        public string Name3;
        public string Qm3;

        public int imagenum;
        public string Name;
        public string Qm;
        #endregion

        //显示结果
        public void show() {
            DB db = new DB();
            string sql;
            try
            {
                db.dbOpen();//打开数据库;

                string sql1 = "select count(*) from QQUsers where QQ='" + this.txtwhere.Text + "'";
                SqlCommand com = new SqlCommand(sql1, db.Conn);
                if (Regex.IsMatch(this.txtwhere.Text.Trim(), "^\\d+$") && (int)com.ExecuteScalar() == 1)
                {
                    sql = "select * from QQUsers where QQ='" + this.txtwhere.Text + "'";
                }
                else
                {
                    sql = "select * from QQUsers where Name like '%" + this.txtwhere.Text + "%'";
                }
                SqlCommand comm = new SqlCommand(sql, db.Conn);

                int index = 0;
                SqlDataReader rd = comm.ExecuteReader();
                while (rd.Read()) 
                {
                    if (index == 0) {
                         imagenum0=Convert.ToInt32(rd["imagenum"]);
                         Name0=rd["Name"].ToString();
                         Qm0=rd["qianming"].ToString();

                        this.p1.BackgroundImage = QQimage.Images[Convert.ToInt32(rd["imagenum"])];
                        this.name1.Text = rd["Name"].ToString();
                        this.qm1.Text = rd["qianming"].ToString();
                    }
                    else if (index == 1) {
                         imagenum1=Convert.ToInt32(rd["imagenum"]);
                         Name1 = rd["Name"].ToString();
                         Qm1=rd["qianming"].ToString();

                        this.p2.BackgroundImage = QQimage.Images[Convert.ToInt32(rd["imagenum"])];
                        this.name2.Text = rd["Name"].ToString();
                        this.qm2.Text = rd["qianming"].ToString();
                    }
                    else if (index == 2) {
                         imagenum2=Convert.ToInt32(rd["imagenum"]);
                         Name2 = rd["Name"].ToString();
                         Qm2=rd["qianming"].ToString();

                        this.p3.BackgroundImage = QQimage.Images[Convert.ToInt32(rd["imagenum"])];
                        this.name3.Text = rd["Name"].ToString();
                        this.qm3.Text = rd["qianming"].ToString();
                    }
                    else if (index == 3) {
                        imagenum3 = Convert.ToInt32(rd["imagenum"]);
                        Name3 = rd["Name"].ToString();
                         Qm3=rd["qianming"].ToString();

                        this.p4.BackgroundImage = QQimage.Images[Convert.ToInt32(rd["imagenum"])];
                        this.name4.Text = rd["Name"].ToString();
                        this.qm4.Text = rd["qianming"].ToString();
                    }
                    index++;                    
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void p4_Click(object sender, EventArgs e)
        {
            QQUserAdd QQAdd = new QQUserAdd();
            QQAdd.imagenum = imagenum3;
            QQAdd.Name = Name3;
            QQAdd.Qm = Qm3;
            QQAdd.ShowDialog();
        }

        private void name1_Click(object sender, EventArgs e)
        {

        }

        private void p1_Click(object sender, EventArgs e)
        {
          QQUserAdd QQAdd =  new QQUserAdd();
          QQAdd.imagenum = imagenum0;
          QQAdd.Name = Name0;
          QQAdd.Qm = Qm0;
          QQAdd.ShowDialog();
        }

        private void p2_Click(object sender, EventArgs e)
        {
            QQUserAdd QQAdd = new QQUserAdd();
            QQAdd.imagenum = imagenum1;
            QQAdd.Name = Name1;
            QQAdd.Qm = Qm1;
            QQAdd.ShowDialog();
        }

        private void p3_Click(object sender, EventArgs e)
        {
            QQUserAdd QQAdd = new QQUserAdd();
            QQAdd.imagenum = imagenum2;
            QQAdd.Name = Name2;
            QQAdd.Qm = Qm2;
            QQAdd.ShowDialog();
        }
    }
}
