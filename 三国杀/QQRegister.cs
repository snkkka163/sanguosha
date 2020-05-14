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
    public partial class frmRegister : Form
    {
        DB db = new DB();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
        Random rd = new Random();
        //录入信息
        public void MessageAdd() {
            try
            {
                if (this.txtid.Text != "" && this.txtpwd.Text != "")
                {
                    db.dbOpen();
                    int numrd = rd.Next(10000000, 100000000);
                    string sql1 = "insert into QQUsers(QQ,Name,PassWord)values ('" + numrd.ToString() + "','" + this.txtid.Text + "','" + this.txtpwd.Text + "')";
                    SqlCommand comm = new SqlCommand(sql1, db.Conn);
                    int num = comm.ExecuteNonQuery();
                    if (num != 0)
                    {
                        MessageBox.Show("注册成功,您的QQ账号为:" + numrd);
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("注册失败");
                    }
                }
                else {
                    MessageBox.Show("用户名或者密码不能为空请重新输入");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageAdd();
        }
    }
}
