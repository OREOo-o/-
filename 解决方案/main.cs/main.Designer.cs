namespace sql_homework_end
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_logintime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(923, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息ToolStripMenuItem,
            this.课程信息ToolStripMenuItem,
            this.选课信息ToolStripMenuItem,
            this.管理员信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1048, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生信息ToolStripMenuItem
            // 
            this.学生信息ToolStripMenuItem.Name = "学生信息ToolStripMenuItem";
            this.学生信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.学生信息ToolStripMenuItem.Text = "学生信息";
            this.学生信息ToolStripMenuItem.Click += new System.EventHandler(this.学生信息ToolStripMenuItem_Click);
            // 
            // 课程信息ToolStripMenuItem
            // 
            this.课程信息ToolStripMenuItem.Name = "课程信息ToolStripMenuItem";
            this.课程信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.课程信息ToolStripMenuItem.Text = "课程信息";
            this.课程信息ToolStripMenuItem.Click += new System.EventHandler(this.课程信息ToolStripMenuItem_Click);
            // 
            // 选课信息ToolStripMenuItem
            // 
            this.选课信息ToolStripMenuItem.Name = "选课信息ToolStripMenuItem";
            this.选课信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.选课信息ToolStripMenuItem.Text = "选课信息";
            this.选课信息ToolStripMenuItem.Click += new System.EventHandler(this.选课信息ToolStripMenuItem_Click);
            // 
            // 管理员信息ToolStripMenuItem
            // 
            this.管理员信息ToolStripMenuItem.Name = "管理员信息ToolStripMenuItem";
            this.管理员信息ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.管理员信息ToolStripMenuItem.Text = "管理员信息";
            this.管理员信息ToolStripMenuItem.Click += new System.EventHandler(this.管理员信息ToolStripMenuItem_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(27, 363);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(100, 27);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "添加";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(158, 363);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 27);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "更新";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(296, 363);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 27);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(695, 10);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(71, 15);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "username";
            // 
            // lbl_logintime
            // 
            this.lbl_logintime.AutoSize = true;
            this.lbl_logintime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logintime.Location = new System.Drawing.Point(24, 481);
            this.lbl_logintime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_logintime.Name = "lbl_logintime";
            this.lbl_logintime.Size = new System.Drawing.Size(87, 15);
            this.lbl_logintime.TabIndex = 5;
            this.lbl_logintime.Text = "login_time";
            this.lbl_logintime.Click += new System.EventHandler(this.lbl_logintime_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1048, 583);
            this.Controls.Add(this.lbl_logintime);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "main";
            this.Text = "学生信息管理系统";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课信息ToolStripMenuItem;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ToolStripMenuItem 管理员信息ToolStripMenuItem;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_logintime;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

