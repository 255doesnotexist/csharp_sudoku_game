using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace SudokuGame
{
    public class User
    {
        public string Name { get; set; }
        public bool IsLastArcadeMode = false;
        public User()
        {
        }

        public User(string name)
        {
            Name = name;
        }

        public string LastArcadeGameSavePath()
        {
            return Name + ".arcade.sudoku";
        }

        public void SaveUserFile() // 把当前用户保存到文件
        {
            string Path = Name + ".user";
            StreamWriter sw = new StreamWriter(Path);
            sw.WriteLine("{0}", Name);
            sw.WriteLine("{0}", IsLastArcadeMode);
            sw.Close();
        }
        public void ReadUserFile() // 读取文件到当前用户
        {
            string Path = Name + ".user";
            StreamReader rw = new StreamReader(Path);
            Name = rw.ReadLine();
            IsLastArcadeMode = bool.Parse(rw.ReadLine());
            rw.Close();
        }
    }
}
