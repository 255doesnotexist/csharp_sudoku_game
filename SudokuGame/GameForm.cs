using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SudokuGame
{
    public partial class GameForm : Form
    {
        private Button[,] SudokuButtons = new Button[10, 10];
        private TableLayoutPanel[,] TbLayouts = new TableLayoutPanel[4, 4];
        private Sudoku sudoku = new Sudoku();
        private bool EditorMode = false;
        private string Gamemode = "解题模式";
        private string SaveGamePath = "";
        private User user;
        private DateTime BeginTime = new DateTime(), EndTime = new DateTime();
        private TimeSpan LastTimeSpan = new TimeSpan();
        public GameForm(Sudoku InitSudoku, User InitUser, bool InitEditorMode, string initSaveGamePath)
        {
            InitializeComponent();
            sudoku = InitSudoku;
            EditorMode = InitEditorMode;
            user = InitUser;
            SaveGamePath = initSaveGamePath;
        }

        private void UpdateSudokuButtons()
        {
            int FilledCount = 0;
            for (int i = 1; i <= 9; ++i)
            {
                for (int j = 1; j <= 9; ++j)
                {
                    if (sudoku[i, j] != 0)
                    {
                        SudokuButtons[i, j].Text = sudoku[i, j].ToString();
                        SudokuButtons[i, j].Enabled = false;
                        ++FilledCount;
                    }
                    else
                    {
                        SudokuButtons[i, j].Text = "";
                        SudokuButtons[i, j].Enabled = true;
                    }

                    if (Gamemode == "编辑模式") SudokuButtons[i, j].Enabled = true;
                    if (sudoku.Writable[i, j]) SudokuButtons[i, j].Enabled = true;
                }
            }

            LabelMysteryRemains.Text = string.Format("您距离胜利还有还有 {0} 个格子未填！", 81 - FilledCount);
        }
        private void SudokuButtonOnClick(object sender, int i, int j)
        {
            if (Gamemode == "提示模式")
            {
                List<int> solutionInts = new List<int>();
                int BackupValue = sudoku[i, j];
                for (int t = 1; t <= 9; ++t)
                {
                    sudoku[i, j] = t;
                    if (sudoku.IsSudokuValid())
                    {
                        solutionInts.Add(t);
                    }
                }
                sudoku[i, j] = BackupValue;

                if (solutionInts.Count > 0)
                {
                    string msg = "此处有以下可能的可行解：";
                    bool flg = false;
                    foreach (int x in solutionInts)
                    {
                        if(flg) msg += string.Format(", {0}", x);
                        else
                        {
                            msg += string.Format(" {0}", x);
                            flg = true;
                        }
                    }

                    msg += "。";
                    MessageBox.Show(msg);
                }
                else
                {
                    MessageBox.Show("此处无解。");
                }
            }
            else
            {
                string StrInput = Interaction.InputBox("你想将此处设置为何值呢？", "请输入一个1~9的整数", "0");
                int BackupValue = sudoku[i, j];
                try
                {
                    sudoku[i, j] = int.Parse(StrInput);
                    sudoku.Writable[i, j] = true;
                    if (!sudoku.IsSudokuValid())
                    {
                        throw new Exception("不能构成数独。");
                    }
                }
                catch (Exception ex)
                {
                    sudoku[i, j] = BackupValue;
                    MessageBox.Show("输入的值不合法。");
                }

                UpdateSudokuButtons();
            }
            sudoku.SaveSudokuFile(SaveGamePath);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; ++i)
            {
                for (int j = 1; j <= 3; ++j)
                {
                    TbLayouts[i, j] = new TableLayoutPanel();
                    TbLayoutSudoku.Controls.Add(TbLayouts[i, j], i - 1, j - 1);
                    TbLayouts[i, j].Dock = DockStyle.Fill;
                    TbLayouts[i, j].CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                    for (int t = 1; t <= 3; ++t)
                    {
                        TbLayouts[i, j].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
                    }

                    for (int t = 1; t <= 3; ++t)
                    {
                        TbLayouts[i, j].RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
                    }
                }
            }

            for (int i = 1; i <= 9; ++i)
            {
                for (int j = 1; j <= 9; ++j)
                {
                    SudokuButtons[i, j] = new Button();
                    TbLayouts[(i - 1) / 3 + 1,(j - 1) / 3 + 1].Controls.Add(SudokuButtons[i, j], (i - 1) % 3, (j - 1) % 3);
                    SudokuButtons[i, j].Dock = DockStyle.Fill;
                    SudokuButtons[i, j].Name = string.Format("{0},{1}",i,j);
                    SudokuButtons[i, j].Click += delegate(Object sender_, EventArgs e_)
                    {
                        string[] x = ((Button)sender_).Name.Split(',');
                        i = int.Parse(x[0]);
                        j = int.Parse(x[1]);
                        SudokuButtonOnClick(SudokuButtons[i, j], i, j);
                    };
                    SudokuButtons[i, j].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
                }
            }

            if (EditorMode) // 编辑模式则仅开放编辑、提示功能
            {
                RbEdit.Checked = true;
                RbSolve.Enabled = false;
            }
            else // 否则开放解题、提示功能
            {
                RbSolve.Checked = true;
                RbEdit.Enabled = false;
            }

            UpdateSudokuButtons(); // 首次初始化数独界面
            this.Text += "\t当前登入用户：" + user.Name;
            BeginTime = DateTime.Now; // 记录进入时间
            LastTimeSpan = sudoku.GameTime; // 从上次的游戏时间继续开始计时
        }

        private void RbSolve_CheckedChanged(object sender, EventArgs e)
        {
            Gamemode = ((RadioButton)sender).Text;
        }

        private void RbHint_CheckedChanged(object sender, EventArgs e)
        {
            Gamemode = ((RadioButton)sender).Text;
        }

        private void RbEdit_CheckedChanged(object sender, EventArgs e)
        {
            Gamemode = ((RadioButton)sender).Text;
        }

        private void ButtonOpenSudoku_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "数独文件(*.sudoku)|*.sudoku";
            ofd.ShowDialog();
            if (ofd.FileName == null) return;
            if (File.Exists(ofd.FileName))
            {
                sudoku.ReadSudokuFile(ofd.FileName);
                UpdateSudokuButtons();
            }
        }

        private void ButtonSaveSudoku_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "数独文件(*.sudoku)|*.sudoku";
            ofd.ShowDialog();
            if (ofd.FileName == null) return;
            sudoku.SaveSudokuFile(ofd.FileName);
            UpdateSudokuButtons();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sudoku.SaveSudokuFile(SaveGamePath);
        }

        private void ButtonSolveSudoku_Click(object sender, EventArgs e)
        {
            if (sudoku.Count < 9)
            {
                if (MessageBox.Show("您未填的格子数过多，继续自动解题可能使程序无响应。是否继续自动解题？", "警告", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning)
                    != DialogResult.Yes)
                {
                    return;
                }
            }

            sudoku = CommonUtils.SolveSudoku(sudoku);
            UpdateSudokuButtons();
            sudoku.SaveSudokuFile(SaveGamePath);
        }

        private void TickTimer_Tick(object sender, EventArgs e)
        {
            EndTime = DateTime.Now;
            sudoku.GameTime = EndTime - BeginTime + LastTimeSpan;
            user.SaveUserFile();

            LabelTimer.Text = "您已经花了 " + sudoku.GameTime.ToString(@"hh\ \时\ mm\ \分\ ss\ \秒") + "来解题了。";

            if (sudoku.Count == 81)
            {
                TickTimer.Enabled = false;
                if (sudoku.ShortestTime > sudoku.GameTime)
                {
                    sudoku.ShortestTime = sudoku.GameTime;
                    sudoku.RecordUser = user.Name;
                }
                MessageBox.Show(string.Format("您赢了！\n\n耗时: {0}\n史上最佳：{1}",
                    sudoku.GameTime.ToString(@"hh\ \时\ mm\ \分\ ss\ \秒"),
                    sudoku.ShortestTime.ToString(@"hh\ \时\ mm\ \分\ ss\ \秒")));
                this.Close();
                sudoku.GameTime = TimeSpan.Zero;
                sudoku.SaveSudokuFile(SaveGamePath);
            }
        }
    }
}
