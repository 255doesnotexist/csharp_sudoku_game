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
            this.CbEditorMode = new System.Windows.Forms.CheckBox();
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
            this.TbLoginLayout.Name = "TbLoginLayout";
            this.TbLoginLayout.RowCount = 1;
            this.TbLoginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbLoginLayout.Size = new System.Drawing.Size(647, 457);
            this.TbLoginLayout.TabIndex = 1;
            // 
            // ListUsers
            // 
            this.ListUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListUsers.FormattingEnabled = true;
            this.ListUsers.ItemHeight = 24;
            this.ListUsers.Location = new System.Drawing.Point(3, 3);
            this.ListUsers.Name = "ListUsers";
            this.ListUsers.Size = new System.Drawing.Size(441, 451);
            this.ListUsers.TabIndex = 2;
            // 
            // FlLayout
            // 
            this.FlLayout.Controls.Add(this.ButtonLogin);
            this.FlLayout.Controls.Add(this.ButtonRegister);
            this.FlLayout.Controls.Add(this.CbEditorMode);
            this.FlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlLayout.Location = new System.Drawing.Point(450, 3);
            this.FlLayout.Name = "FlLayout";
            this.FlLayout.Size = new System.Drawing.Size(194, 451);
            this.FlLayout.TabIndex = 3;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.AutoSize = true;
            this.ButtonLogin.Location = new System.Drawing.Point(3, 3);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(180, 80);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "用户登录";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.AutoSize = true;
            this.ButtonRegister.Location = new System.Drawing.Point(3, 89);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(180, 80);
            this.ButtonRegister.TabIndex = 1;
            this.ButtonRegister.Text = "新建用户";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // CbEditorMode
            // 
            this.CbEditorMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbEditorMode.AutoSize = true;
            this.CbEditorMode.Location = new System.Drawing.Point(3, 175);
            this.CbEditorMode.Name = "CbEditorMode";
            this.CbEditorMode.Size = new System.Drawing.Size(138, 28);
            this.CbEditorMode.TabIndex = 2;
            this.CbEditorMode.Text = "编辑模式";
            this.CbEditorMode.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 457);
            this.Controls.Add(this.TbLoginLayout);
            this.Name = "LoginForm";
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
        private System.Windows.Forms.CheckBox CbEditorMode;
    }
}