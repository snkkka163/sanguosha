using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 三国杀
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QQLogin login = new QQLogin();
            this.Opacity = 0.5;
            login.ShowDialog();
            if (login.Visible == false)
            {
                this.Opacity = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //IntPtr handle = this.Handle;
        } 
        

    }
}
