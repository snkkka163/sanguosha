namespace 三国杀
{
    partial class QQMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QQMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qqimages = new System.Windows.Forms.ImageList(this.components);
            this.txtname = new System.Windows.Forms.Label();
            this.qianming = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 63);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // qqimages
            // 
            this.qqimages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("qqimages.ImageStream")));
            this.qqimages.TransparentColor = System.Drawing.Color.Transparent;
            this.qqimages.Images.SetKeyName(0, "qq1.jpg");
            this.qqimages.Images.SetKeyName(1, "qq2.jpg");
            this.qqimages.Images.SetKeyName(2, "qq3.jpg");
            this.qqimages.Images.SetKeyName(3, "qq4.jpg");
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.BackColor = System.Drawing.Color.Transparent;
            this.txtname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtname.ForeColor = System.Drawing.Color.White;
            this.txtname.Location = new System.Drawing.Point(108, 37);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(84, 27);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "QQ昵称";
            // 
            // qianming
            // 
            this.qianming.AutoSize = true;
            this.qianming.BackColor = System.Drawing.Color.Transparent;
            this.qianming.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qianming.Location = new System.Drawing.Point(110, 85);
            this.qianming.Name = "qianming";
            this.qianming.Size = new System.Drawing.Size(120, 15);
            this.qianming.TabIndex = 2;
            this.qianming.Text = "个性签名:未设置";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(290, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(35, 767);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 33);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // frmQQMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::三国杀.Properties.Resources.loginsss;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(321, 805);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.qianming);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQQMain";
            this.Text = "frmQQMain";
            this.Load += new System.EventHandler(this.frmQQMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmQQMain_MouseDown);
            this.MouseEnter += new System.EventHandler(this.frmQQMain_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.frmQQMain_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmQQMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmQQMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList qqimages;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label qianming;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}