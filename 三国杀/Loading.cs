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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        int i=0;

        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 1) {
                this.BackgroundImage = Image.FromFile("./load/load1.png");
            }
            if (i == 2)
            {
                this.BackgroundImage = Image.FromFile("./load/load2.png");
            }
            if (i == 3)
            {
                this.BackgroundImage = Image.FromFile("./load/load3.png");
            }
            if (i == 4)
            {
                this.BackgroundImage = Image.FromFile("./load/load4.png");
            }
            //this.label1.Text = i.ToString();
            if (i == 5) {
                new GameMain().Show();
                this.Hide();
                this.timer.Enabled = false;
            }
        }


        private void frmLoad1_Load(object sender, EventArgs e)
        {
        }
    }
}