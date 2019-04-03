namespace SmartLab.APP.Admin
{
    partial class ChangeAdminPasswd
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
            this.bg = new System.Windows.Forms.Panel();
            this.CurtainRight = new System.Windows.Forms.Panel();
            this.tile = new System.Windows.Forms.Panel();
            this.tilelabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.confirmlabel = new System.Windows.Forms.Label();
            this.newpasswdlabel = new System.Windows.Forms.Label();
            this.oldpaswdlable = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CurtainLeft = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ALLPIC = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.returnSelection = new System.Windows.Forms.Button();
            this.Functionnamelabel = new System.Windows.Forms.Label();
            this.SingOut = new System.Windows.Forms.Button();
            this.sysname = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.bg.SuspendLayout();
            this.CurtainRight.SuspendLayout();
            this.tile.SuspendLayout();
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
            this.bg.TabIndex = 3;
            // 
            // CurtainRight
            // 
            this.CurtainRight.AutoScroll = true;
            this.CurtainRight.BackColor = System.Drawing.Color.Transparent;
            this.CurtainRight.BackgroundImage = global::SmartLab.Properties.Resources.幕布_右边;
            this.CurtainRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CurtainRight.Controls.Add(this.tile);
            this.CurtainRight.Controls.Add(this.button4);
            this.CurtainRight.Controls.Add(this.confirmlabel);
            this.CurtainRight.Controls.Add(this.newpasswdlabel);
            this.CurtainRight.Controls.Add(this.oldpaswdlable);
            this.CurtainRight.Controls.Add(this.textBox3);
            this.CurtainRight.Controls.Add(this.textBox2);
            this.CurtainRight.Controls.Add(this.textBox1);
            this.CurtainRight.Location = new System.Drawing.Point(532, 251);
            this.CurtainRight.Name = "CurtainRight";
            this.CurtainRight.Size = new System.Drawing.Size(1291, 731);
            this.CurtainRight.TabIndex = 3;
            // 
            // tile
            // 
            this.tile.BackgroundImage = global::SmartLab.Properties.Resources.标题;
            this.tile.Controls.Add(this.tilelabel);
            this.tile.Location = new System.Drawing.Point(172, 27);
            this.tile.Name = "tile";
            this.tile.Size = new System.Drawing.Size(954, 61);
            this.tile.TabIndex = 7;
            // 
            // tilelabel
            // 
            this.tilelabel.AutoSize = true;
            this.tilelabel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tilelabel.ForeColor = System.Drawing.Color.Black;
            this.tilelabel.Location = new System.Drawing.Point(378, 20);
            this.tilelabel.Name = "tilelabel";
            this.tilelabel.Size = new System.Drawing.Size(159, 28);
            this.tilelabel.TabIndex = 0;
            this.tilelabel.Text = "管理员修改密码";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::SmartLab.Properties.Resources.棕提交;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(571, 522);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "确认修改";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // confirmlabel
            // 
            this.confirmlabel.AutoSize = true;
            this.confirmlabel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmlabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.confirmlabel.Location = new System.Drawing.Point(421, 367);
            this.confirmlabel.Name = "confirmlabel";
            this.confirmlabel.Size = new System.Drawing.Size(117, 28);
            this.confirmlabel.TabIndex = 5;
            this.confirmlabel.Text = "确认密码：";
            // 
            // newpasswdlabel
            // 
            this.newpasswdlabel.AutoSize = true;
            this.newpasswdlabel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newpasswdlabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.newpasswdlabel.Location = new System.Drawing.Point(434, 292);
            this.newpasswdlabel.Name = "newpasswdlabel";
            this.newpasswdlabel.Size = new System.Drawing.Size(96, 28);
            this.newpasswdlabel.TabIndex = 4;
            this.newpasswdlabel.Text = "新密码：";
            // 
            // oldpaswdlable
            // 
            this.oldpaswdlable.AutoSize = true;
            this.oldpaswdlable.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oldpaswdlable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.oldpaswdlable.Location = new System.Drawing.Point(434, 209);
            this.oldpaswdlable.Name = "oldpaswdlable";
            this.oldpaswdlable.Size = new System.Drawing.Size(96, 28);
            this.oldpaswdlable.TabIndex = 3;
            this.oldpaswdlable.Text = "原密码：";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.textBox3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(555, 292);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(327, 35);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(555, 367);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(327, 35);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(555, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(327, 35);
            this.textBox1.TabIndex = 0;
            // 
            // CurtainLeft
            // 
            this.CurtainLeft.BackColor = System.Drawing.Color.Transparent;
            this.CurtainLeft.BackgroundImage = global::SmartLab.Properties.Resources.幕布;
            this.CurtainLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CurtainLeft.Controls.Add(this.button2);
            this.CurtainLeft.Controls.Add(this.button1);
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
            this.button2.BackgroundImage = global::SmartLab.Properties.Resources.棕选择条;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(413, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "          管理员密码修改";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(413, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "          添加管理员";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
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
            this.ALLPIC.Text = "          查看门禁权限列表";
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
            this.Functionnamelabel.Size = new System.Drawing.Size(239, 33);
            this.Functionnamelabel.TabIndex = 3;
            this.Functionnamelabel.Text = "管理员密码修改";
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
            // ChangeAdminPasswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeAdminPasswd";
            this.Text = "ChangeAdminPasswd";
            this.bg.ResumeLayout(false);
            this.CurtainRight.ResumeLayout(false);
            this.CurtainRight.PerformLayout();
            this.tile.ResumeLayout(false);
            this.tile.PerformLayout();
            this.CurtainLeft.ResumeLayout(false);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bg;
        private System.Windows.Forms.Panel CurtainRight;
        private System.Windows.Forms.Label confirmlabel;
        private System.Windows.Forms.Label newpasswdlabel;
        private System.Windows.Forms.Label oldpaswdlable;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel CurtainLeft;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ALLPIC;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Button returnSelection;
        private System.Windows.Forms.Label Functionnamelabel;
        private System.Windows.Forms.Button SingOut;
        private System.Windows.Forms.Label sysname;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel tile;
        private System.Windows.Forms.Label tilelabel;
    }
}