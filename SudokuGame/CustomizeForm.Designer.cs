namespace SudokuGame
{
    partial class CustomizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizeForm));
            this.TbLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonGenerateSudoku = new System.Windows.Forms.Button();
            this.TextSudokuRemains = new System.Windows.Forms.TextBox();
            this.TrackBarSudokuRemains = new System.Windows.Forms.TrackBar();
            this.TbLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSudokuRemains)).BeginInit();
            this.SuspendLayout();
            // 
            // TbLayoutMain
            // 
            this.TbLayoutMain.ColumnCount = 2;
            this.TbLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TbLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbLayoutMain.Controls.Add(this.ButtonGenerateSudoku, 0, 1);
            this.TbLayoutMain.Controls.Add(this.TextSudokuRemains, 1, 0);
            this.TbLayoutMain.Controls.Add(this.TrackBarSudokuRemains, 0, 0);
            this.TbLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.TbLayoutMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TbLayoutMain.Name = "TbLayoutMain";
            this.TbLayoutMain.RowCount = 2;
            this.TbLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbLayoutMain.Size = new System.Drawing.Size(822, 116);
            this.TbLayoutMain.TabIndex = 0;
            // 
            // ButtonGenerateSudoku
            // 
            this.TbLayoutMain.SetColumnSpan(this.ButtonGenerateSudoku, 2);
            this.ButtonGenerateSudoku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonGenerateSudoku.Location = new System.Drawing.Point(6, 64);
            this.ButtonGenerateSudoku.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonGenerateSudoku.Name = "ButtonGenerateSudoku";
            this.ButtonGenerateSudoku.Size = new System.Drawing.Size(810, 46);
            this.ButtonGenerateSudoku.TabIndex = 2;
            this.ButtonGenerateSudoku.Text = "生成自定义难度数独";
            this.ButtonGenerateSudoku.UseVisualStyleBackColor = true;
            this.ButtonGenerateSudoku.Click += new System.EventHandler(this.ButtonGenerateSudoku_Click);
            // 
            // TextSudokuRemains
            // 
            this.TextSudokuRemains.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextSudokuRemains.Location = new System.Drawing.Point(663, 17);
            this.TextSudokuRemains.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextSudokuRemains.Name = "TextSudokuRemains";
            this.TextSudokuRemains.Size = new System.Drawing.Size(153, 35);
            this.TextSudokuRemains.TabIndex = 1;
            this.TextSudokuRemains.Text = "0";
            this.TextSudokuRemains.TextChanged += new System.EventHandler(this.TextSudokuRemains_TextChanged);
            // 
            // TrackBarSudokuRemains
            // 
            this.TrackBarSudokuRemains.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TrackBarSudokuRemains.LargeChange = 30;
            this.TrackBarSudokuRemains.Location = new System.Drawing.Point(6, 6);
            this.TrackBarSudokuRemains.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TrackBarSudokuRemains.Maximum = 81;
            this.TrackBarSudokuRemains.Name = "TrackBarSudokuRemains";
            this.TrackBarSudokuRemains.Size = new System.Drawing.Size(645, 46);
            this.TrackBarSudokuRemains.TabIndex = 0;
            this.TrackBarSudokuRemains.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarSudokuRemains.Scroll += new System.EventHandler(this.TrackBarSudokuRemains_Scroll);
            // 
            // CustomizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 116);
            this.Controls.Add(this.TbLayoutMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CustomizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请选择你需要生成差几步完成的数独";
            this.TbLayoutMain.ResumeLayout(false);
            this.TbLayoutMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSudokuRemains)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TbLayoutMain;
        private System.Windows.Forms.TrackBar TrackBarSudokuRemains;
        private System.Windows.Forms.TextBox TextSudokuRemains;
        private System.Windows.Forms.Button ButtonGenerateSudoku;
    }
}