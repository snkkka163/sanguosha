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
    public partial class GameMain : Form
    {
        public GameMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        double num;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num <= 1) {
                num += 0.1;
            }
            this.Opacity = num;
        }

        bool x;
        bool y;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //if (this.pictureBox1.Location.Y > this.pictureBox2.Location.Y)
            //{
            //    this.pictureBox2.Top += 10;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.timer2.Enabled = true;
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new pvp().Show();
        }
    }
}
