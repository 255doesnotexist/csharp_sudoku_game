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
            this.TbLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.TrackBarSudokuRemains = new System.Windows.Forms.TrackBar();
            this.TextSudokuRemains = new System.Windows.Forms.TextBox();
            this.ButtonGenerateSudoku = new System.Windows.Forms.Button();
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
            this.TbLayoutMain.Name = "TbLayoutMain";
            this.TbLayoutMain.RowCount = 2;
            this.TbLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbLayoutMain.Size = new System.Drawing.Size(411, 58);
            this.TbLayoutMain.TabIndex = 0;
            // 
            // TrackBarSudokuRemains
            // 
            this.TrackBarSudokuRemains.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TrackBarSudokuRemains.LargeChange = 30;
            this.TrackBarSudokuRemains.Location = new System.Drawing.Point(3, 3);
            this.TrackBarSudokuRemains.Maximum = 81;
            this.TrackBarSudokuRemains.Name = "TrackBarSudokuRemains";
            this.TrackBarSudokuRemains.Size = new System.Drawing.Size(322, 23);
            this.TrackBarSudokuRemains.TabIndex = 0;
            this.TrackBarSudokuRemains.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarSudokuRemains.Scroll += new System.EventHandler(this.TrackBarSudokuRemains_Scroll);
            // 
            // TextSudokuRemains
            // 
            this.TextSudokuRemains.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextSudokuRemains.Location = new System.Drawing.Point(331, 5);
            this.TextSudokuRemains.Name = "TextSudokuRemains";
            this.TextSudokuRemains.Size = new System.Drawing.Size(77, 21);
            this.TextSudokuRemains.TabIndex = 1;
            this.TextSudokuRemains.Text = "0";
            this.TextSudokuRemains.TextChanged += new System.EventHandler(this.TextSudokuRemains_TextChanged);
            // 
            // ButtonGenerateSudoku
            // 
            this.TbLayoutMain.SetColumnSpan(this.ButtonGenerateSudoku, 2);
            this.ButtonGenerateSudoku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonGenerateSudoku.Location = new System.Drawing.Point(3, 32);
            this.ButtonGenerateSudoku.Name = "ButtonGenerateSudoku";
            this.ButtonGenerateSudoku.Size = new System.Drawing.Size(405, 23);
            this.ButtonGenerateSudoku.TabIndex = 2;
            this.ButtonGenerateSudoku.Text = "生成自定义难度数独";
            this.ButtonGenerateSudoku.UseVisualStyleBackColor = true;
            this.ButtonGenerateSudoku.Click += new System.EventHandler(this.ButtonGenerateSudoku_Click);
            // 
            // CustomizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 58);
            this.Controls.Add(this.TbLayoutMain);
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