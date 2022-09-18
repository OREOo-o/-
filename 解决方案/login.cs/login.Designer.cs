namespace sql_homework_end
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_loginname = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.lbl_loginname = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.cmb_identity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(382, 361);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎进入学生信息管理系统！";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbx_loginname
            // 
            this.tbx_loginname.Location = new System.Drawing.Point(152, 77);
            this.tbx_loginname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_loginname.Name = "tbx_loginname";
            this.tbx_loginname.Size = new System.Drawing.Size(197, 25);
            this.tbx_loginname.TabIndex = 1;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(152, 128);
            this.tbx_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(197, 25);
            this.tbx_password.TabIndex = 2;
            // 
            // lbl_loginname
            // 
            this.lbl_loginname.AutoSize = true;
            this.lbl_loginname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loginname.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_loginname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_loginname.Location = new System.Drawing.Point(68, 80);
            this.lbl_loginname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_loginname.Name = "lbl_loginname";
            this.lbl_loginname.Size = new System.Drawing.Size(52, 15);
            this.lbl_loginname.TabIndex = 3;
            this.lbl_loginname.Text = "登录名";
            this.lbl_loginname.Click += new System.EventHandler(this.lbl_loginname_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Location = new System.Drawing.Point(83, 128);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(37, 15);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "密码";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(114, 232);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(79, 27);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(260, 232);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 27);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "退出";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // cmb_identity
            // 
            this.cmb_identity.FormattingEnabled = true;
            this.cmb_identity.Items.AddRange(new object[] {
            "学生",
            "管理员"});
            this.cmb_identity.Location = new System.Drawing.Point(260, 183);
            this.cmb_identity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_identity.Name = "cmb_identity";
            this.cmb_identity.Size = new System.Drawing.Size(89, 23);
            this.cmb_identity.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(81, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "选择你的身份：";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(655, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_identity);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_loginname);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_loginname);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "login";
            this.Text = "学生信息管理系统登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_loginname;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label lbl_loginname;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cmb_identity;
        private System.Windows.Forms.Label label2;
    }
}
