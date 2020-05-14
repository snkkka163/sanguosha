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
namespace 三国杀
{
    public partial class QQLogin : Form
    {
        public QQLogin()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new frmRegister().ShowDialog();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login();
        }

        DB db = new DB();
        //登录按钮事件
        public void Login() {
            if (this.txtzhanghao.Text != "")
            {
                if (this.txtpassword.Text != "")
                {
                    db.dbOpen();
                    string sql = "select count(*) from QQUsers where QQ='"+this.txtzhanghao.Text+"' and Pwd='"+this.txtpassword.Text+"'";
                    SqlCommand comm = new SqlCommand(sql, db.Conn);
                    int num = (int)comm.ExecuteScalar();
                    if (num == 1)
                    {
                        new Loading().Show();
                        QQMain QQMain = new QQMain();
                        QQMain.Userid = this.txtzhanghao.Text;
                        QQMain.password = this.txtpassword.Text;
                        QQMain.Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("账号或密码错误，登录失败");
                    }
                }
                else {
                    MessageBox.Show("QQ密码不能为空请重新输入");
                    this.txtpassword.Focus();
                }
            }
            else {
                MessageBox.Show("QQ账号不能为空请重新输入");
                this.txtzhanghao.Focus();
            }
        }
    }
}
