using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SudokuGame
{
    public partial class TopListForm : Form
    {
        public TopListForm()
        {
            InitializeComponent();
        }

        private void TopListForm_Load(object sender, EventArgs e)
        {
            LabelTopList.Text = "当前闯关模式的最佳记录如下：\n";
            FileInfo[] fn = new DirectoryInfo("./").GetFiles();
            string[] path = new string[11];
            for (int i = 0; i <= 10; ++i)
            {
                path[i] = "";
            }
            foreach (var x in fn)
            {
                if (x.Name.EndsWith(".arcade.sudoku"))
                {
                    string id = x.Name.Substring(x.Name.IndexOf(".") + 1,
                        x.Name.IndexOf(".arcade.sudoku") - x.Name.IndexOf(".") - 1);
                    Sudoku pre = new Sudoku(), cur = new Sudoku();
                    if (File.Exists(path[int.Parse(id)])){
                        pre.ReadSudokuFile(path[int.Parse(id)]);
                    }
                    cur.ReadSudokuFile(x.Name);
                    if (cur.ShortestTime < pre.ShortestTime)
                    {
                        path[int.Parse(id)] = x.Name;
                    }
                }
            }
            for (int i = 1; i <= 10; ++i)
            {
                if(File.Exists(path[i]))
                {
                    Sudoku x = new Sudoku();
                    x.ReadSudokuFile(path[i]);
                    LabelTopList.Text += string.Format("\n第 {0} 关最佳记录为 {1}。由 {2} 取得。", i,
                        x.ShortestTime.ToString(@"hh\ \时\ mm\ \分\ ss\ \秒"), x.RecordUser);
                }
                else
                {
                    LabelTopList.Text += string.Format("\n第 {0} 关无人通关，暂无最佳成绩。", i);
                }
            }
        }
    }
}
