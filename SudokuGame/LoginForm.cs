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
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath);
            FileInfo[]  fi = di.GetFiles("*.user");
            ListUsers.Items.Clear();
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
            if (File.Exists(user.LastGameSavePath()) && MessageBox.Show("是否读取上次存档？","提示",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Sudoku sudoku = new Sudoku();
                sudoku.ReadSudokuFile(user.LastGameSavePath());
                GmForm = new GameForm(sudoku, user, CbEditorMode.Checked);
            }
            else if(CbEditorMode.Checked) // 创意工坊自由模式
            {
                MessageBox.Show("检测到您勾选了编辑模式，即将进入自制数独模式。\n您可以通过右下角的另存数独功能保存您制作的数独谜题，可用于上传至互联网与他人分享。");
                GmForm = new GameForm(new Sudoku(), user, CbEditorMode.Checked);
            }
            else
            {
                MessageBox.Show("即将加载系统内置数独谜题。");
                Sudoku sudoku = new Sudoku();
                sudoku.WriteDefaultSudokuFile();
                sudoku.ReadSudokuFile("default.sudoku");
                GmForm = new GameForm(sudoku, user, CbEditorMode.Checked);
            }
            GmForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            RefreshUsers();
        }
    }
}
