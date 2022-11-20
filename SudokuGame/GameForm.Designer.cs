namespace SudokuGame
{
    partial class GameForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TbLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.TbLayoutSudoku = new System.Windows.Forms.TableLayoutPanel();
            this.GbSolveOrHint = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RbEdit = new System.Windows.Forms.RadioButton();
            this.RbSolve = new System.Windows.Forms.RadioButton();
            this.RbHint = new System.Windows.Forms.RadioButton();
            this.TbForButtons = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonOpenSudoku = new System.Windows.Forms.Button();
            this.ButtonSaveSudoku = new System.Windows.Forms.Button();
            this.LabelMysteryRemains = new System.Windows.Forms.Label();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.TickTimer = new System.Windows.Forms.Timer(this.components);
            this.TbLayoutMain.SuspendLayout();
            this.GbSolveOrHint.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TbForButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbLayoutMain
            // 
            this.TbLayoutMain.ColumnCount = 2;
            this.TbLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TbLayoutMain.Controls.Add(this.TbLayoutSudoku, 0, 0);
            this.TbLayoutMain.Controls.Add(this.GbSolveOrHint, 0, 1);
            this.TbLayoutMain.Controls.Add(this.TbForButtons, 1, 1);
            this.TbLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.TbLayoutMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbLayoutMain.Name = "TbLayoutMain";
            this.TbLayoutMain.RowCount = 2;
            this.TbLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TbLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbLayoutMain.Size = new System.Drawing.Size(467, 470);
            this.TbLayoutMain.TabIndex = 0;
            // 
            // TbLayoutSudoku
            // 
            this.TbLayoutSudoku.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TbLayoutSudoku.ColumnCount = 3;
            this.TbLayoutMain.SetColumnSpan(this.TbLayoutSudoku, 2);
            this.TbLayoutSudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TbLayoutSudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TbLayoutSudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TbLayoutSudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbLayoutSudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbLayoutSudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbLayoutSudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbLayoutSudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbLayoutSudoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbLayoutSudoku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbLayoutSudoku.Location = new System.Drawing.Point(2, 2);
            this.TbLayoutSudoku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbLayoutSudoku.Name = "TbLayoutSudoku";
            this.TbLayoutSudoku.RowCount = 3;
            this.TbLayoutSudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TbLayoutSudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TbLayoutSudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TbLayoutSudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbLayoutSudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbLayoutSudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbLayoutSudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbLayoutSudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbLayoutSudoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbLayoutSudoku.Size = new System.Drawing.Size(463, 372);
            this.TbLayoutSudoku.TabIndex = 0;
            // 
            // GbSolveOrHint
            // 
            this.GbSolveOrHint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbSolveOrHint.Controls.Add(this.tableLayoutPanel1);
            this.GbSolveOrHint.Location = new System.Drawing.Point(2, 378);
            this.GbSolveOrHint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbSolveOrHint.Name = "GbSolveOrHint";
            this.GbSolveOrHint.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbSolveOrHint.Size = new System.Drawing.Size(89, 90);
            this.GbSolveOrHint.TabIndex = 1;
            this.GbSolveOrHint.TabStop = false;
            this.GbSolveOrHint.Text = "操作模式";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.RbEdit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RbSolve, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RbHint, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(85, 72);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RbEdit
            // 
            this.RbEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RbEdit.AutoSize = true;
            this.RbEdit.Location = new System.Drawing.Point(2, 48);
            this.RbEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbEdit.Name = "RbEdit";
            this.RbEdit.Size = new System.Drawing.Size(81, 22);
            this.RbEdit.TabIndex = 4;
            this.RbEdit.TabStop = true;
            this.RbEdit.Text = "编辑模式";
            this.RbEdit.UseVisualStyleBackColor = true;
            this.RbEdit.CheckedChanged += new System.EventHandler(this.RbEdit_CheckedChanged);
            // 
            // RbSolve
            // 
            this.RbSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RbSolve.AutoSize = true;
            this.RbSolve.Location = new System.Drawing.Point(2, 2);
            this.RbSolve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbSolve.Name = "RbSolve";
            this.RbSolve.Size = new System.Drawing.Size(81, 19);
            this.RbSolve.TabIndex = 2;
            this.RbSolve.TabStop = true;
            this.RbSolve.Text = "解题模式";
            this.RbSolve.UseVisualStyleBackColor = true;
            this.RbSolve.CheckedChanged += new System.EventHandler(this.RbSolve_CheckedChanged);
            // 
            // RbHint
            // 
            this.RbHint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RbHint.AutoSize = true;
            this.RbHint.Location = new System.Drawing.Point(2, 25);
            this.RbHint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbHint.Name = "RbHint";
            this.RbHint.Size = new System.Drawing.Size(81, 19);
            this.RbHint.TabIndex = 3;
            this.RbHint.TabStop = true;
            this.RbHint.Text = "提示模式";
            this.RbHint.UseVisualStyleBackColor = true;
            this.RbHint.CheckedChanged += new System.EventHandler(this.RbHint_CheckedChanged);
            // 
            // TbForButtons
            // 
            this.TbForButtons.ColumnCount = 2;
            this.TbForButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TbForButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbForButtons.Controls.Add(this.ButtonOpenSudoku, 1, 0);
            this.TbForButtons.Controls.Add(this.ButtonSaveSudoku, 1, 1);
            this.TbForButtons.Controls.Add(this.LabelMysteryRemains, 0, 0);
            this.TbForButtons.Controls.Add(this.LabelTimer, 0, 1);
            this.TbForButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbForButtons.Location = new System.Drawing.Point(95, 378);
            this.TbForButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbForButtons.Name = "TbForButtons";
            this.TbForButtons.RowCount = 2;
            this.TbForButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbForButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbForButtons.Size = new System.Drawing.Size(370, 90);
            this.TbForButtons.TabIndex = 2;
            // 
            // ButtonOpenSudoku
            // 
            this.ButtonOpenSudoku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonOpenSudoku.Location = new System.Drawing.Point(298, 2);
            this.ButtonOpenSudoku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonOpenSudoku.Name = "ButtonOpenSudoku";
            this.ButtonOpenSudoku.Size = new System.Drawing.Size(70, 41);
            this.ButtonOpenSudoku.TabIndex = 0;
            this.ButtonOpenSudoku.Text = "加载数独";
            this.ButtonOpenSudoku.UseVisualStyleBackColor = true;
            this.ButtonOpenSudoku.Click += new System.EventHandler(this.ButtonOpenSudoku_Click);
            // 
            // ButtonSaveSudoku
            // 
            this.ButtonSaveSudoku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSaveSudoku.Location = new System.Drawing.Point(298, 47);
            this.ButtonSaveSudoku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonSaveSudoku.Name = "ButtonSaveSudoku";
            this.ButtonSaveSudoku.Size = new System.Drawing.Size(70, 41);
            this.ButtonSaveSudoku.TabIndex = 1;
            this.ButtonSaveSudoku.Text = "另存数独";
            this.ButtonSaveSudoku.UseVisualStyleBackColor = true;
            this.ButtonSaveSudoku.Click += new System.EventHandler(this.ButtonSaveSudoku_Click);
            // 
            // LabelMysteryRemains
            // 
            this.LabelMysteryRemains.AutoSize = true;
            this.LabelMysteryRemains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelMysteryRemains.Location = new System.Drawing.Point(2, 0);
            this.LabelMysteryRemains.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMysteryRemains.Name = "LabelMysteryRemains";
            this.LabelMysteryRemains.Size = new System.Drawing.Size(292, 45);
            this.LabelMysteryRemains.TabIndex = 2;
            this.LabelMysteryRemains.Text = "这里将显示您还有几步可获得胜利。";
            this.LabelMysteryRemains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTimer.Location = new System.Drawing.Point(2, 45);
            this.LabelTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(292, 45);
            this.LabelTimer.TabIndex = 3;
            this.LabelTimer.Text = "这里将显示您的解题时长。";
            this.LabelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TickTimer
            // 
            this.TickTimer.Enabled = true;
            this.TickTimer.Interval = 1000;
            this.TickTimer.Tick += new System.EventHandler(this.TickTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 470);
            this.Controls.Add(this.TbLayoutMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameForm";
            this.Text = "数独游戏 by255";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TbLayoutMain.ResumeLayout(false);
            this.GbSolveOrHint.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TbForButtons.ResumeLayout(false);
            this.TbForButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TbLayoutMain;
        private System.Windows.Forms.TableLayoutPanel TbLayoutSudoku;
        private System.Windows.Forms.GroupBox GbSolveOrHint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton RbEdit;
        private System.Windows.Forms.RadioButton RbSolve;
        private System.Windows.Forms.RadioButton RbHint;
        private System.Windows.Forms.TableLayoutPanel TbForButtons;
        private System.Windows.Forms.Button ButtonOpenSudoku;
        private System.Windows.Forms.Button ButtonSaveSudoku;
        private System.Windows.Forms.Label LabelMysteryRemains;
        private System.Windows.Forms.Label LabelTimer;
        private System.Windows.Forms.Timer TickTimer;
    }
}

