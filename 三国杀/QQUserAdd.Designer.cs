namespace 三国杀
{
    partial class QQUserAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QQUserAdd));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.QQname = new System.Windows.Forms.Label();
            this.QQqm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "qq1.jpg");
            this.imageList1.Images.SetKeyName(1, "qq2.jpg");
            this.imageList1.Images.SetKeyName(2, "qq3.jpg");
            this.imageList1.Images.SetKeyName(3, "qq4.jpg");
            // 
            // QQname
            // 
            this.QQname.AutoSize = true;
            this.QQname.BackColor = System.Drawing.Color.Transparent;
            this.QQname.Location = new System.Drawing.Point(25, 151);
            this.QQname.Name = "QQname";
            this.QQname.Size = new System.Drawing.Size(0, 15);
            this.QQname.TabIndex = 1;
            // 
            // QQqm
            // 
            this.QQqm.AutoSize = true;
            this.QQqm.BackColor = System.Drawing.Color.Transparent;
            this.QQqm.Location = new System.Drawing.Point(25, 191);
            this.QQqm.Name = "QQqm";
            this.QQqm.Size = new System.Drawing.Size(0, 15);
            this.QQqm.TabIndex = 2;
            // 
            // QQUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::三国杀.Properties.Resources.无标题2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 443);
            this.Controls.Add(this.QQqm);
            this.Controls.Add(this.QQname);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QQUserAdd";
            this.Text = "QQUserAdd";
            this.Load += new System.EventHandler(this.QQUserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label QQname;
        private System.Windows.Forms.Label QQqm;
    }
}