namespace SudokuGame
{
    partial class SelectForm
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
            this.TbLayoutSelect = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // TbLayoutSelect
            // 
            this.TbLayoutSelect.ColumnCount = 5;
            this.TbLayoutSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbLayoutSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbLayoutSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbLayoutSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbLayoutSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbLayoutSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbLayoutSelect.Location = new System.Drawing.Point(0, 0);
            this.TbLayoutSelect.Name = "TbLayoutSelect";
            this.TbLayoutSelect.RowCount = 2;
            this.TbLayoutSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbLayoutSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbLayoutSelect.Size = new System.Drawing.Size(316, 117);
            this.TbLayoutSelect.TabIndex = 0;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 117);
            this.Controls.Add(this.TbLayoutSelect);
            this.Name = "SelectForm";
            this.Text = "选择关卡（越往后越难）";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TbLayoutSelect;
    }
}