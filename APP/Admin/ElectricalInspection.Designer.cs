namespace SmartLab.APP.Admin
{
    partial class ElectricalInspection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectricalInspection));
            this.bg = new System.Windows.Forms.Panel();
            this.CurtainRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CurtainLeft = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ALLPIC = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.returnSelection = new System.Windows.Forms.Button();
            this.Functionnamelabel = new System.Windows.Forms.Label();
            this.SingOut = new System.Windows.Forms.Button();
            this.sysname = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bg.SuspendLayout();
            this.CurtainRight.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.bg.TabIndex = 4;
            // 
            // CurtainRight
            // 
            this.CurtainRight.AutoScroll = true;
            this.CurtainRight.BackColor = System.Drawing.Color.Transparent;
            this.CurtainRight.BackgroundImage = global::SmartLab.Properties.Resources.幕布_右边;
            this.CurtainRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CurtainRight.Controls.Add(this.button6);
            this.CurtainRight.Controls.Add(this.button5);
            this.CurtainRight.Controls.Add(this.button4);
            this.CurtainRight.Controls.Add(this.panel1);
            this.CurtainRight.Location = new System.Drawing.Point(532, 251);
            this.CurtainRight.Name = "CurtainRight";
            this.CurtainRight.Size = new System.Drawing.Size(1291, 731);
            this.CurtainRight.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(106, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 77);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口号-分类-用电类型-功率";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurtainLeft
            // 
            this.CurtainLeft.BackColor = System.Drawing.Color.Transparent;
            this.CurtainLeft.BackgroundImage = global::SmartLab.Properties.Resources.幕布;
            this.CurtainLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CurtainLeft.Controls.Add(this.button2);
            this.CurtainLeft.Controls.Add(this.ALLPIC);
            this.CurtainLeft.ForeColor = System.Drawing.Color.White;
            this.CurtainLeft.Location = new System.Drawing.Point(113, 251);
            this.CurtainLeft.Name = "CurtainLeft";
            this.CurtainLeft.Size = new System.Drawing.Size(413, 731);
            this.CurtainLeft.TabIndex = 2;
            this.CurtainLeft.TabStop = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::SmartLab.Properties.Resources.黄选择条;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(410, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "          管理员密码修改";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ALLPIC
            // 
            this.ALLPIC.BackColor = System.Drawing.Color.Transparent;
            this.ALLPIC.FlatAppearance.BorderSize = 0;
            this.ALLPIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ALLPIC.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ALLPIC.ForeColor = System.Drawing.Color.Black;
            this.ALLPIC.Location = new System.Drawing.Point(0, 0);
            this.ALLPIC.Name = "ALLPIC";
            this.ALLPIC.Size = new System.Drawing.Size(413, 50);
            this.ALLPIC.TabIndex = 2;
            this.ALLPIC.Text = "          用户信息导入";
            this.ALLPIC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ALLPIC.UseVisualStyleBackColor = false;
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
            // 
            // Functionnamelabel
            // 
            this.Functionnamelabel.AutoSize = true;
            this.Functionnamelabel.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Functionnamelabel.Location = new System.Drawing.Point(895, 134);
            this.Functionnamelabel.Name = "Functionnamelabel";
            this.Functionnamelabel.Size = new System.Drawing.Size(143, 33);
            this.Functionnamelabel.TabIndex = 3;
            this.Functionnamelabel.Text = "电器查看";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1036, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 62);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(937, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 62);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(618, 674);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 46);
            this.button6.TabIndex = 11;
            this.button6.Text = "1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(1235, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 54);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(22, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 54);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ElectricalInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ElectricalInspection";
            this.Text = "ElectricalInspection";
            this.bg.ResumeLayout(false);
            this.CurtainRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CurtainLeft.ResumeLayout(false);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bg;
        private System.Windows.Forms.Panel CurtainRight;
        private System.Windows.Forms.Panel CurtainLeft;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ALLPIC;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Button returnSelection;
        private System.Windows.Forms.Label Functionnamelabel;
        private System.Windows.Forms.Button SingOut;
        private System.Windows.Forms.Label sysname;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}