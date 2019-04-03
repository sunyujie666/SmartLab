namespace SmartLab.APP.Admin
{
    partial class AdministratorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorLogin));
            this.bg = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.Panel();
            this.ForgetPassword = new System.Windows.Forms.Label();
            this.tile = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Panel();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Panel();
            this.account = new System.Windows.Forms.TextBox();
            this.Singin = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bg.SuspendLayout();
            this.Password.SuspendLayout();
            this.UserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.BackColor = System.Drawing.Color.White;
            this.bg.BackgroundImage = global::SmartLab.Properties.Resources.背景图;
            this.bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg.Controls.Add(this.pic);
            this.bg.Controls.Add(this.ForgetPassword);
            this.bg.Controls.Add(this.tile);
            this.bg.Controls.Add(this.Password);
            this.bg.Controls.Add(this.UserName);
            this.bg.Controls.Add(this.Singin);
            this.bg.Controls.Add(this.flowLayoutPanel1);
            this.bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg.Location = new System.Drawing.Point(0, 0);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(1378, 780);
            this.bg.TabIndex = 0;
            this.bg.Paint += new System.Windows.Forms.PaintEventHandler(this.bg_Paint);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic.BackgroundImage")));
            this.pic.Location = new System.Drawing.Point(450, 350);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(522, 424);
            this.pic.TabIndex = 0;
            // 
            // ForgetPassword
            // 
            this.ForgetPassword.AutoSize = true;
            this.ForgetPassword.BackColor = System.Drawing.Color.White;
            this.ForgetPassword.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForgetPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ForgetPassword.Location = new System.Drawing.Point(1350, 580);
            this.ForgetPassword.Name = "ForgetPassword";
            this.ForgetPassword.Size = new System.Drawing.Size(104, 19);
            this.ForgetPassword.TabIndex = 0;
            this.ForgetPassword.Text = "忘记密码？";
            this.ForgetPassword.Click += new System.EventHandler(this.ForgetPassword_Click);
            // 
            // tile
            // 
            this.tile.AutoSize = true;
            this.tile.BackColor = System.Drawing.Color.White;
            this.tile.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tile.Location = new System.Drawing.Point(1053, 300);
            this.tile.Name = "tile";
            this.tile.Size = new System.Drawing.Size(452, 48);
            this.tile.TabIndex = 0;
            this.tile.Text = "智慧实验室管理登陆";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Password.BackgroundImage")));
            this.Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Password.Controls.Add(this.passwordtext);
            this.Password.Location = new System.Drawing.Point(1093, 500);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(360, 52);
            this.Password.TabIndex = 2;
            // 
            // passwordtext
            // 
            this.passwordtext.BackColor = System.Drawing.SystemColors.Window;
            this.passwordtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtext.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordtext.Location = new System.Drawing.Point(57, 3);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.PasswordChar = '·';
            this.passwordtext.Size = new System.Drawing.Size(300, 22);
            this.passwordtext.TabIndex = 4;
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.White;
            this.UserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserName.BackgroundImage")));
            this.UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserName.Controls.Add(this.account);
            this.UserName.Location = new System.Drawing.Point(1093, 400);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(360, 52);
            this.UserName.TabIndex = 1;
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.SystemColors.Window;
            this.account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.account.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.account.Location = new System.Drawing.Point(60, 3);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(300, 22);
            this.account.TabIndex = 3;
            // 
            // Singin
            // 
            this.Singin.BackColor = System.Drawing.Color.White;
            this.Singin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Singin.BackgroundImage")));
            this.Singin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Singin.FlatAppearance.BorderSize = 0;
            this.Singin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Singin.Font = new System.Drawing.Font("黑体", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Singin.ForeColor = System.Drawing.Color.White;
            this.Singin.Location = new System.Drawing.Point(1093, 650);
            this.Singin.Name = "Singin";
            this.Singin.Size = new System.Drawing.Size(320, 66);
            this.Singin.TabIndex = 0;
            this.Singin.Text = "登录";
            this.Singin.UseVisualStyleBackColor = false;
            this.Singin.Click += new System.EventHandler(this.Singin_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(260, 190);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1400, 700);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AdministratorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministratorLogin";
            this.Text = "AdministratorLogin";
            this.bg.ResumeLayout(false);
            this.bg.PerformLayout();
            this.Password.ResumeLayout(false);
            this.Password.PerformLayout();
            this.UserName.ResumeLayout(false);
            this.UserName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel UserName;
        private System.Windows.Forms.Button Singin;
        private System.Windows.Forms.Panel Password;
        private System.Windows.Forms.Label ForgetPassword;
        private System.Windows.Forms.Label tile;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Panel pic;
    }
}