namespace SmartLab.APP.Admin
{
    partial class PictureManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureManagement));
            this.bg = new System.Windows.Forms.Panel();
            this.CurtainRight = new System.Windows.Forms.Panel();
            this.CurtainLeft = new System.Windows.Forms.Panel();
            this.uppic = new System.Windows.Forms.Button();
            this.ALLPIC = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.returnSelection = new System.Windows.Forms.Button();
            this.Functionnamelabel = new System.Windows.Forms.Label();
            this.SingOut = new System.Windows.Forms.Button();
            this.sysname = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bg.SuspendLayout();
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
            this.bg.TabIndex = 0;
            // 
            // CurtainRight
            // 
            this.CurtainRight.AutoScroll = true;
            this.CurtainRight.BackColor = System.Drawing.Color.White;
            this.CurtainRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CurtainRight.Location = new System.Drawing.Point(532, 251);
            this.CurtainRight.Name = "CurtainRight";
            this.CurtainRight.Size = new System.Drawing.Size(1291, 731);
            this.CurtainRight.TabIndex = 3;
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
            this.uppic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uppic.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uppic.ForeColor = System.Drawing.Color.Black;
            this.uppic.Location = new System.Drawing.Point(0, 50);
            this.uppic.Name = "uppic";
            this.uppic.Size = new System.Drawing.Size(413, 50);
            this.uppic.TabIndex = 3;
            this.uppic.Text = "          上传图片";
            this.uppic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uppic.UseVisualStyleBackColor = true;
            this.uppic.Click += new System.EventHandler(this.uppic_Click);
            // 
            // ALLPIC
            // 
            this.ALLPIC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ALLPIC.BackgroundImage")));
            this.ALLPIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ALLPIC.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ALLPIC.Location = new System.Drawing.Point(0, 0);
            this.ALLPIC.Name = "ALLPIC";
            this.ALLPIC.Size = new System.Drawing.Size(413, 50);
            this.ALLPIC.TabIndex = 2;
            this.ALLPIC.Text = "          所有图片";
            this.ALLPIC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ALLPIC.UseVisualStyleBackColor = true;
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
            this.returnSelection.Location = new System.Drawing.Point(3, 121);
            this.returnSelection.Name = "returnSelection";
            this.returnSelection.Size = new System.Drawing.Size(64, 64);
            this.returnSelection.TabIndex = 4;
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
            // PictureManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PictureManagement";
            this.Text = "PictureManagement";
            this.Load += new System.EventHandler(this.PictureManagement_Load);
            this.bg.ResumeLayout(false);
            this.CurtainLeft.ResumeLayout(false);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bg;
        private System.Windows.Forms.Panel CurtainLeft;
        private System.Windows.Forms.Panel CurtainRight;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label Functionnamelabel;
        private System.Windows.Forms.Button SingOut;
        private System.Windows.Forms.Label sysname;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button uppic;
        private System.Windows.Forms.Button ALLPIC;
        private System.Windows.Forms.Button returnSelection;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}