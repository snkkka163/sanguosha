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
    public partial class QQMain : Form
    {
        public QQMain()
        {
            InitializeComponent();
        }
        Point mousePosition;

        Point formPosition;

        bool isMouseDown = false;//是否按下

        bool isMouseIn = false;//是否在窗体内
        private void frmQQMain_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;

            mousePosition = Control.MousePosition;  //鼠标位置

            formPosition = this.Location;   //窗体左上角位置
        }

        private void frmQQMain_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void frmQQMain_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePoint = Control.MousePosition;   //移动的位置
            if (isMouseDown && isMouseIn) {
                this.Location = new Point(mousePoint.X - mousePosition.X + formPosition.X, mousePoint.Y - mousePosition.Y + formPosition.Y);
            }
        }

        private void frmQQMain_MouseEnter(object sender, EventArgs e)
        {
            isMouseIn = true;
        }

        private void frmQQMain_MouseLeave(object sender, EventArgs e)
        {
            isMouseIn = false;
        }

        private void frmQQMain_Load(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = this.qqimages.Images[0];
            MessageBox.Show(Userid);
            iconshow();
        }
        public string Userid;
        public string password;
        //获取当前QQ的头像
        public void iconshow() {
            DB db = new DB();
            try
            {
                db.dbOpen();
                string sql = "select * from QQUsers";
                SqlCommand comm = new SqlCommand(sql, db.Conn);
                SqlDataReader read=comm.ExecuteReader();
                while(read.Read()){
                    if (read["QQ"].ToString().Equals(Userid)&&read["PassWord"].ToString().Equals(password)) {
                        this.pictureBox1.BackgroundImage = this.qqimages.Images[Convert.ToInt32(read["imagenum"])];
                        this.txtname.Text = read["QQname"].ToString();
                        this.qianming.Text = read["qianming"].ToString();
                    }
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new QQSearch().Show();
        }
    }
}
