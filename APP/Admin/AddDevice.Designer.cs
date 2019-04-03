namespace SmartLab.APP.Admin
{
    partial class AddDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDevice));
            this.bg = new System.Windows.Forms.Panel();
            this.CurtainRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CurtainLeft = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ALLPIC = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.returnSelection = new System.Windows.Forms.Button();
            this.Functionnamelabel = new System.Windows.Forms.Label();
            this.SingOut = new System.Windows.Forms.Button();
            this.sysname = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.bg.SuspendLayout();
            this.CurtainRight.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.bg.TabIndex = 5;
            // 
            // CurtainRight
            // 
            this.CurtainRight.AutoScroll = true;
            this.CurtainRight.BackColor = System.Drawing.Color.Transparent;
            this.CurtainRight.BackgroundImage = global::SmartLab.Properties.Resources.幕布_右边;
            this.CurtainRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CurtainRight.Controls.Add(this.panel2);
            this.CurtainRight.Controls.Add(this.panel1);
            this.CurtainRight.Location = new System.Drawing.Point(532, 251);
            this.CurtainRight.Name = "CurtainRight";
            this.CurtainRight.Size = new System.Drawing.Size(1291, 731);
            this.CurtainRight.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.namelabel);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(285, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 731);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(125, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(671, 47);
            this.panel4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(82, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "电器已连接空闲接口";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(412, 570);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 46);
            this.button4.TabIndex = 10;
            this.button4.Text = "提交";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(238)))));
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "长期供电",
            "有人通电"});
            this.comboBox2.Location = new System.Drawing.Point(364, 338);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(288, 46);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Text = "请选择分类";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(245, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "分类：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(187, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "用电类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(245, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "功率：";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(238)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(364, 418);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 46);
            this.textBox2.TabIndex = 5;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(238)))));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(364, 167);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(288, 46);
            this.name.TabIndex = 3;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.namelabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.namelabel.Location = new System.Drawing.Point(245, 175);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(104, 38);
            this.namelabel.TabIndex = 2;
            this.namelabel.Text = "端口：";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(238)))));
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "长期供电",
            "有人通电"});
            this.comboBox1.Location = new System.Drawing.Point(364, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 46);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "请选择分类";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 731);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(22, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 54);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(82, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "接口1";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(108, 661);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 54);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(108, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 54);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
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
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(413, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "          电器查看";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ALLPIC
            // 
            this.ALLPIC.BackColor = System.Drawing.Color.Transparent;
            this.ALLPIC.BackgroundImage = global::SmartLab.Properties.Resources.黄选择条;
            this.ALLPIC.FlatAppearance.BorderSize = 0;
            this.ALLPIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ALLPIC.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ALLPIC.ForeColor = System.Drawing.Color.Black;
            this.ALLPIC.Location = new System.Drawing.Point(0, 0);
            this.ALLPIC.Name = "ALLPIC";
            this.ALLPIC.Size = new System.Drawing.Size(413, 50);
            this.ALLPIC.TabIndex = 2;
            this.ALLPIC.Text = "          添加设备";
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
            this.Functionnamelabel.Text = "添加设备";
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
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDevice";
            this.Text = "AddDevice";
            this.bg.ResumeLayout(false);
            this.CurtainRight.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}