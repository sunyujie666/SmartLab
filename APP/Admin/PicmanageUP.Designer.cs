namespace SmartLab.APP.Admin
{
    partial class PicmanageUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicmanageUP));
            this.bg = new System.Windows.Forms.Panel();
            this.CurtainRight = new System.Windows.Forms.Panel();
            this.Areyousure = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileselect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CurtainLeft = new System.Windows.Forms.Panel();
            this.uppic = new System.Windows.Forms.Button();
            this.ALLPIC = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.returnSelection = new System.Windows.Forms.Button();
            this.Functionnamelabel = new System.Windows.Forms.Label();
            this.SingOut = new System.Windows.Forms.Button();
            this.sysname = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.bg.SuspendLayout();
            this.CurtainRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).BeginInit();
            this.CurtainLeft.SuspendLayout();
            this.top.SuspendLayout();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.BackgroundImage = global::SmartLab.Properties.Resources.背景图;
            this.bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg.Controls.Add(this.CurtainRight);
            this.bg.Controls.Add(this.CurtainLeft);
            this.bg.Controls.Add(this.top);
            this.bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg.Location = new System.Drawing.Point(0, 0);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(1920, 1080);
            this.bg.TabIndex = 1;
            // 
            // CurtainRight
            // 
            this.CurtainRight.AutoScroll = true;
            this.CurtainRight.BackColor = System.Drawing.Color.Transparent;
            this.CurtainRight.BackgroundImage = global::SmartLab.Properties.Resources.幕布_右边;
            this.CurtainRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CurtainRight.Controls.Add(this.Areyousure);
            this.CurtainRight.Controls.Add(this.Show);
            this.CurtainRight.Controls.Add(this.label2);
            this.CurtainRight.Controls.Add(this.label1);
            this.CurtainRight.Controls.Add(this.fileselect);
            this.CurtainRight.Controls.Add(this.textBox1);
            this.CurtainRight.Location = new System.Drawing.Point(532, 251);
            this.CurtainRight.Name = "CurtainRight";
            this.CurtainRight.Size = new System.Drawing.Size(1291, 731);
            this.CurtainRight.TabIndex = 3;
            // 
            // Areyousure
            // 
            this.Areyousure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(158)))), ((int)(((byte)(246)))));
            this.Areyousure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Areyousure.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Areyousure.Location = new System.Drawing.Point(589, 550);
            this.Areyousure.Name = "Areyousure";
            this.Areyousure.Size = new System.Drawing.Size(105, 40);
            this.Areyousure.TabIndex = 5;
            this.Areyousure.Text = "确认";
            this.Areyousure.UseVisualStyleBackColor = false;
            this.Areyousure.Click += new System.EventHandler(this.Areyousure_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(466, 284);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(320, 180);
            this.Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Show.TabIndex = 4;
            this.Show.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(323, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "提示：如果上传的图片为背景图片，建议大小不小于1M。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(187, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "图片上传：";
            // 
            // fileselect
            // 
            this.fileselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileselect.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileselect.ForeColor = System.Drawing.Color.Black;
            this.fileselect.Location = new System.Drawing.Point(982, 101);
            this.fileselect.Name = "fileselect";
            this.fileselect.Size = new System.Drawing.Size(55, 39);
            this.fileselect.TabIndex = 1;
            this.fileselect.Text = "...";
            this.fileselect.UseVisualStyleBackColor = true;
            this.fileselect.Click += new System.EventHandler(this.fileselect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(327, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(659, 39);
            this.textBox1.TabIndex = 0;
            // 
            // CurtainLeft
            // 
            this.CurtainLeft.BackColor = System.Drawing.Color.Transparent;
            this.CurtainLeft.BackgroundImage = global::SmartLab.Properties.Resources.幕布;
            this.CurtainLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CurtainLeft.Controls.Add(this.uppic);
            this.CurtainLeft.Controls.Add(this.ALLPIC);
            this.CurtainLeft.ForeColor = System.Drawing.Color.White;
            this.CurtainLeft.Location = new System.Drawing.Point(113, 251);
            this.CurtainLeft.Name = "CurtainLeft";
            this.CurtainLeft.Size = new System.Drawing.Size(413, 731);
            this.CurtainLeft.TabIndex = 2;
            this.CurtainLeft.TabStop = true;
            // 
            // uppic
            // 
            this.uppic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uppic.BackgroundImage")));
            this.uppic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uppic.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uppic.ForeColor = System.Drawing.Color.White;
            this.uppic.Location = new System.Drawing.Point(0, 50);
            this.uppic.Name = "uppic";
            this.uppic.Size = new System.Drawing.Size(413, 50);
            this.uppic.TabIndex = 3;
            this.uppic.Text = "          上传图片";
            this.uppic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uppic.UseVisualStyleBackColor = true;
            // 
            // ALLPIC
            // 
            this.ALLPIC.BackColor = System.Drawing.Color.Transparent;
            this.ALLPIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ALLPIC.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ALLPIC.ForeColor = System.Drawing.Color.Black;
            this.ALLPIC.Location = new System.Drawing.Point(0, 0);
            this.ALLPIC.Name = "ALLPIC";
            this.ALLPIC.Size = new System.Drawing.Size(413, 50);
            this.ALLPIC.TabIndex = 2;
            this.ALLPIC.Text = "          所有图片";
            this.ALLPIC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ALLPIC.UseVisualStyleBackColor = false;
            this.ALLPIC.Click += new System.EventHandler(this.ALLPIC_Click);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Transparent;
            this.top.BackgroundImage = global::SmartLab.Properties.Resources.顶栏;
            this.top.Controls.Add(this.returnSelection);
            this.top.Controls.Add(this.Functionnamelabel);
            this.top.Controls.Add(this.SingOut);
            this.top.Controls.Add(this.sysname);
            this.top.Controls.Add(this.logo);
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1920, 188);
            this.top.TabIndex = 1;
            // 
            // returnSelection
            // 
            this.returnSelection.BackgroundImage = global::SmartLab.Properties.Resources.返回;
            this.returnSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnSelection.Location = new System.Drawing.Point(0, 121);
            this.returnSelection.Name = "returnSelection";
            this.returnSelection.Size = new System.Drawing.Size(64, 64);
            this.returnSelection.TabIndex = 5;
            this.returnSelection.UseVisualStyleBackColor = true;
            this.returnSelection.Click += new System.EventHandler(this.returnSelection_Click);
            // 
            // Functionnamelabel
            // 
            this.Functionnamelabel.AutoSize = true;
            this.Functionnamelabel.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Functionnamelabel.Location = new System.Drawing.Point(895, 134);
            this.Functionnamelabel.Name = "Functionnamelabel";
            this.Functionnamelabel.Size = new System.Drawing.Size(143, 33);
            this.Functionnamelabel.TabIndex = 3;
            this.Functionnamelabel.Text = "图片管理";
            // 
            // SingOut
            // 
            this.SingOut.FlatAppearance.BorderSize = 0;
            this.SingOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingOut.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SingOut.Location = new System.Drawing.Point(1757, 32);
            this.SingOut.Name = "SingOut";
            this.SingOut.Size = new System.Drawing.Size(131, 43);
            this.SingOut.TabIndex = 2;
            this.SingOut.Text = "退出";
            this.SingOut.UseVisualStyleBackColor = true;
            this.SingOut.Click += new System.EventHandler(this.SingOut_Click);
            // 
            // sysname
            // 
            this.sysname.AutoSize = true;
            this.sysname.Font = new System.Drawing.Font("黑体", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sysname.Location = new System.Drawing.Point(133, 36);
            this.sysname.Name = "sysname";
            this.sysname.Size = new System.Drawing.Size(321, 33);
            this.sysname.TabIndex = 1;
            this.sysname.Text = "智能实验室管理系统";
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::SmartLab.Properties.Resources.校标;
            this.logo.Location = new System.Drawing.Point(22, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(89, 89);
            this.logo.TabIndex = 0;
            // 
            // PicmanageUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PicmanageUP";
            this.Text = "PicmanageUP";
            this.Load += new System.EventHandler(this.PicmanageUP_Load);
            this.bg.ResumeLayout(false);
            this.CurtainRight.ResumeLayout(false);
            this.CurtainRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).EndInit();
            this.CurtainLeft.ResumeLayout(false);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bg;
        private System.Windows.Forms.Panel CurtainRight;
        private System.Windows.Forms.Panel CurtainLeft;
        private System.Windows.Forms.Button uppic;
        private System.Windows.Forms.Button ALLPIC;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label Functionnamelabel;
        private System.Windows.Forms.Button SingOut;
        private System.Windows.Forms.Label sysname;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button returnSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fileselect;
        private System.Windows.Forms.PictureBox Show;
        private System.Windows.Forms.Button Areyousure;
    }
}