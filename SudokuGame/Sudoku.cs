using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SudokuGame
{
    public class Sudoku
    {
        public const string DefaultSudoku =
            "560847000309000600008000000010080040790602018050030090000000200006000807000316059001000111010111011110111111101101101001010100101101101111111011110111010111000100";
        protected int[,] SudokuData = new int[10, 10];
        public bool[,] Writable = new bool[10, 10];
        public int Count
        {
            get
            {
                int cnt = 0;
                for (int i = 1; i <= 9; ++i)
                {
                    for (int j = 1; j <= 9; ++j)
                    {
                        if (SudokuData[i,j] != 0) ++cnt;
                    }
                }

                return cnt;
            }
        }

        // 实现一个索引器，允许外部访问内部数独数据
        public int this[int i, int j]
        {
            get
            {
                return SudokuData[i, j];
            }

            set
            {
                SudokuData[i, j] = value;
            }
        }

        public void SaveSudokuFile(string Path) // 把当前数独保存到文件
        {
            StreamWriter sw = new StreamWriter(Path);
            for (int i = 1; i <= 9; ++i)
            {
                for (int j = 1; j <= 9; ++j)
                {
                    // 保存i,j位置的数独数据
                    sw.Write(SudokuData[i, j].ToString());
                }
            }
            for (int i = 1; i <= 9; ++i)
            {
                for (int j = 1; j <= 9; ++j)
                {
                    // 保存i,j位置是否是用户输入
                    int val = (Writable[i, j] ? 1 : 0);
                    // 或未填写
                    if (SudokuData[i, j] == 0) val = 1;
                    sw.Write(val.ToString());
                }
            }
            sw.Close();
        }
        public void ReadSudokuFile(string Path) // 读取文件到当前数独
        {
            StreamReader rw = new StreamReader(Path);
            for (int i = 1; i <= 9; ++i)
            {
                for (int j = 1; j <= 9; ++j)
                {
                    // 读入i,j位置的数独数据
                    SudokuData[i, j] = rw.Read() - '0';
                }
            }
            for (int i = 1; i <= 9; ++i)
            {
                for (int j = 1; j <= 9; ++j)
                {
                    // 读入i,j位置是否是用户输入
                    Writable[i, j] = (rw.Read() - '0' == 1);
                }
            }
            rw.Close();
        }

        public void WriteDefaultSudokuFile()
        {
            StreamWriter sw = new StreamWriter("default.sudoku");
            sw.WriteLine(DefaultSudoku);
            sw.Close();
        }
        public int[,] GetSmallSquare(int line, int row) 
        { // 返回大数独中的小方格
            int[,] Result = new int[4, 4];
            for (int i = 1; i <= 3; ++i)
            {
                for (int j = 1; j <= 3; ++j)
                {
                    Result[i, j] = SudokuData[(line - 1) * 3 + i, (row - 1) * 3 + j];
                }
            }

            return Result;
        }
        public bool IsSudokuValid() // 检查当前数独是否合法
        {
            int[] cnt = new int[10]; // 桶排法检查是否存在重复数字

            for (int i = 1; i <= 3; ++i)
            {
                for (int j = 1; j <= 3; ++j)
                {
                    int[,] Square = GetSmallSquare(i, j);
                    // 获得大方格中的第i行第j列个3*3小方格
                    for (int t = 0; t < 10; ++t) cnt[t] = 0;
                    // 将桶清空
                    for (int x = 1; x <= 3; ++x)
                    {
                        for (int y = 1; y <= 3; ++y)
                        { // 桶计数
                            ++cnt[Square[x,y]];
                        }
                    }

                    for (int t = 1; t <= 9; ++t)
                    {
                        if (cnt[t] >= 2)
                        { // 1~9中任一数字出现超过1次则数独不合法
                            return false;
                        }
                    }
                }
            }

            for (int i = 1; i <= 9; ++i) // 检查每一行是否合法
            {
                for (int t = 0; t < 10; ++t) cnt[t] = 0;
                // 将桶清空
                for (int j = 1; j <= 9; ++j)
                {
                    ++cnt[SudokuData[i, j]];
                }
                for (int t = 1; t <= 9; ++t)
                {
                    if (cnt[t] >= 2)
                    { // 1~9中任一数字出现超过1次则数独不合法
                        return false;
                    }
                }
            }

            for (int i = 1; i <= 9; ++i) // 检查每一列是否合法
            {
                for (int t = 0; t < 10; ++t) cnt[t] = 0;
                // 将桶清空
                for (int j = 1; j <= 9; ++j)
                {
                    ++cnt[SudokuData[j, i]];
                }
                for (int t = 1; t <= 9; ++t)
                {
                    if (cnt[t] >= 2)
                    { // 1~9中任一数字出现超过1次则数独不合法
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
