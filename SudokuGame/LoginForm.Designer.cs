namespace SudokuGame
{
    partial class LoginForm
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
            this.TbLoginLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ListUsers = new System.Windows.Forms.ListBox();
            this.FlLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.ButtonTopList = new System.Windows.Forms.Button();
            this.RbArcadeMode = new System.Windows.Forms.RadioButton();
            this.RbCustomMode = new System.Windows.Forms.RadioButton();
            this.RbEditMode = new System.Windows.Forms.RadioButton();
            this.TbLoginLayout.SuspendLayout();
            this.FlLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbLoginLayout
            // 
            this.TbLoginLayout.ColumnCount = 2;
            this.TbLoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbLoginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TbLoginLayout.Controls.Add(this.ListUsers, 0, 0);
            this.TbLoginLayout.Controls.Add(this.FlLayout, 1, 0);
            this.TbLoginLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbLoginLayout.Location = new System.Drawing.Point(0, 0);
            this.TbLoginLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbLoginLayout.Name = "TbLoginLayout";
            this.TbLoginLayout.RowCount = 1;
            this.TbLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbLoginLayout.Size = new System.Drawing.Size(648, 456);
            this.TbLoginLayout.TabIndex = 1;
            // 
            // ListUsers
            // 
            this.ListUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListUsers.FormattingEnabled = true;
            this.ListUsers.ItemHeight = 24;
            this.ListUsers.Location = new System.Drawing.Point(4, 4);
            this.ListUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListUsers.Name = "ListUsers";
            this.ListUsers.Size = new System.Drawing.Size(440, 448);
            this.ListUsers.TabIndex = 2;
            // 
            // FlLayout
            // 
            this.FlLayout.Controls.Add(this.ButtonLogin);
            this.FlLayout.Controls.Add(this.ButtonRegister);
            this.FlLayout.Controls.Add(this.ButtonTopList);
            this.FlLayout.Controls.Add(this.RbArcadeMode);
            this.FlLayout.Controls.Add(this.RbCustomMode);
            this.FlLayout.Controls.Add(this.RbEditMode);
            this.FlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlLayout.Location = new System.Drawing.Point(452, 4);
            this.FlLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlLayout.Name = "FlLayout";
            this.FlLayout.Size = new System.Drawing.Size(192, 448);
            this.FlLayout.TabIndex = 3;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.AutoSize = true;
            this.ButtonLogin.Location = new System.Drawing.Point(4, 4);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(184, 80);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "用户登录";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.AutoSize = true;
            this.ButtonRegister.Location = new System.Drawing.Point(4, 92);
            this.ButtonRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(184, 80);
            this.ButtonRegister.TabIndex = 1;
            this.ButtonRegister.Text = "新建用户";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // ButtonTopList
            // 
            this.ButtonTopList.AutoSize = true;
            this.FlLayout.SetFlowBreak(this.ButtonTopList, true);
            this.ButtonTopList.Location = new System.Drawing.Point(4, 180);
            this.ButtonTopList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonTopList.Name = "ButtonTopList";
            this.ButtonTopList.Size = new System.Drawing.Size(184, 80);
            this.ButtonTopList.TabIndex = 6;
            this.ButtonTopList.Text = "排行榜";
            this.ButtonTopList.UseVisualStyleBackColor = true;
            this.ButtonTopList.Click += new System.EventHandler(this.ButtonTopList_Click);
            // 
            // RbArcadeMode
            // 
            this.RbArcadeMode.AutoSize = true;
            this.RbArcadeMode.Checked = true;
            this.RbArcadeMode.Location = new System.Drawing.Point(6, 270);
            this.RbArcadeMode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RbArcadeMode.Name = "RbArcadeMode";
            this.RbArcadeMode.Size = new System.Drawing.Size(137, 28);
            this.RbArcadeMode.TabIndex = 3;
            this.RbArcadeMode.TabStop = true;
            this.RbArcadeMode.Text = "闯关模式";
            this.RbArcadeMode.UseVisualStyleBackColor = true;
            // 
            // RbCustomMode
            // 
            this.RbCustomMode.AutoSize = true;
            this.RbCustomMode.Location = new System.Drawing.Point(6, 310);
            this.RbCustomMode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RbCustomMode.Name = "RbCustomMode";
            this.RbCustomMode.Size = new System.Drawing.Size(161, 28);
            this.RbCustomMode.TabIndex = 4;
            this.RbCustomMode.Text = "自定义模式";
            this.RbCustomMode.UseVisualStyleBackColor = true;
            // 
            // RbEditMode
            // 
            this.RbEditMode.AutoSize = true;
            this.RbEditMode.Location = new System.Drawing.Point(6, 350);
            this.RbEditMode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RbEditMode.Name = "RbEditMode";
            this.RbEditMode.Size = new System.Drawing.Size(137, 28);
            this.RbEditMode.TabIndex = 5;
            this.RbEditMode.Text = "编辑模式";
            this.RbEditMode.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 456);
            this.Controls.Add(this.TbLoginLayout);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数独谜题 - 用户登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.TbLoginLayout.ResumeLayout(false);
            this.FlLayout.ResumeLayout(false);
            this.FlLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TbLoginLayout;
        private System.Windows.Forms.ListBox ListUsers;
        private System.Windows.Forms.FlowLayoutPanel FlLayout;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.RadioButton RbArcadeMode;
        private System.Windows.Forms.RadioButton RbCustomMode;
        private System.Windows.Forms.RadioButton RbEditMode;
        private System.Windows.Forms.Button ButtonTopList;
    }
}