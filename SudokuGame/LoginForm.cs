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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void RefreshUsers()
        {
            ListUsers.Items.Clear();
            DirectoryInfo di = new DirectoryInfo("./");
            FileInfo[] fi = di.GetFiles("*.user");
            foreach (var i in fi)
            {
                string username = i.Name.Substring(0, i.Name.Length - ".user".Length);
                ListUsers.Items.Add(username);
            }

            if (ListUsers.Items.Count > 0)
            {
                ListUsers.SelectedIndex = 0;
            }
        }
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            User RegUser = new User
            {
                Name = Interaction.InputBox("输入新的用户名：", "用户注册")
            };
            if (File.Exists(RegUser.Name + ".user"))
            {
                MessageBox.Show("已有同名用户，无法注册！");
                return;
            }
            RegUser.SaveUserFile();
            RefreshUsers();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (ListUsers.SelectedItem == null)
            {
                MessageBox.Show("未选中任何待登录的用户，无法登录。");
                return;
            }
            User user = new User(ListUsers.SelectedItem.ToString());
            user.ReadUserFile();
            Form GmForm = new Form();
            if (RbArcadeMode.Checked)
            { // 若存在上次闯关模式记录
                if (File.Exists(user.LastArcadeGameSavePath()))
                {
                    Sudoku sudoku = new Sudoku();
                    sudoku.ReadSudokuFile(user.LastArcadeGameSavePath());
                    if (sudoku.Count < 81 && MessageBox.Show("是否读取上次闯关模式存档？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        GmForm = new GameForm(sudoku, user, false, user.LastArcadeGameSavePath());
                    }
                    else
                    {
                        GmForm = new SelectForm(user);
                    }
                }
                else
                {
                    GmForm = new SelectForm(user);
                }

                user.IsLastArcadeMode = true;
            }
            else if (RbCustomMode.Checked)
            {
                GmForm = new CustomizeForm(user);
            }
            else if(RbEditMode.Checked) // 创意工坊自由模式
            {
                MessageBox.Show("检测到您勾选了编辑模式，即将进入自制数独模式。\n您可以通过右下角的另存数独功能保存您制作的数独谜题，可用于上传至互联网与他人分享。");
                GmForm = new GameForm(new Sudoku(), user, true, user.Name + ".editmode.sudoku");
            }
            GmForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            /*// Performance Test
            Sudoku sudoku = new Sudoku();
            DateTime firstDateTime = DateTime.Now;
            for (int i = 0; i < 1000; ++i)
            {
                sudoku = CommonUtils.GenerateSudoku(0);
            }
            TimeSpan deltaDateTime = DateTime.Now - firstDateTime;
            MessageBox.Show(deltaDateTime.ToString());*/
            RefreshUsers();
        }

        private void ButtonTopList_Click(object sender, EventArgs e)
        {
            Form TopListForm = new TopListForm();
            TopListForm.ShowDialog();
        }
    }
}
