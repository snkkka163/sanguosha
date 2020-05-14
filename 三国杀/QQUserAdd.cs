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
    public partial class QQUserAdd : Form
    {
        public QQUserAdd()
        {
            InitializeComponent();
        }

            public int imagenum;
            public string Name;
            public string Qm;

        private void QQUserAdd_Load(object sender, EventArgs e)
        {
            this.QQname.Text = Name;
            this.QQqm.Text = Qm;
            this.pictureBox1.BackgroundImage = imageList1.Images[imagenum];
        }
    }
}
