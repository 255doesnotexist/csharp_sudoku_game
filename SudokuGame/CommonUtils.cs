using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SudokuGame
{
    public static class CommonUtils
    {
        public static void swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }

        public static int[] GenerateTenIntMap()
        {
            Random rn = new Random();
            int[] IntMap = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                IntMap[i] = i;
            }
            for (int i = 0; i < 20; ++i)
            {
                swap(ref IntMap[rn.Next(1, 10)], ref IntMap[rn.Next(1, 10)]);
            } // 重设Int的映射，增加算法的可变性

            return IntMap;
        }

        public static Sudoku InternalGenerateSudoku(int i, int j, Sudoku sudoku, int[] IntMap)
        {
            if (j > 9)
            {
                j = 1;
                ++i;
            }

            if (i > 9)
            {
                return sudoku;
            }
            if (sudoku[i, j] != 0)
            {
                return InternalGenerateSudoku(i, j + 1, sudoku, IntMap);
            }

            List<int> ListAnswer = new List<int>();
            for (int t = 1; t <= 9; ++t)
            {
                sudoku[i, j] = t;
                if(sudoku.IsSudokuValid()) ListAnswer.Add(t);
                sudoku[i, j] = 0;
            }

            for (int t = 1; t <= 9; ++t)
            {
                if (IntMap[t] - 1 < ListAnswer.Count)
                {
                    int TT = ListAnswer[IntMap[t] - 1];
                    sudoku[i, j] = TT;
                    sudoku = InternalGenerateSudoku(i, j + 1, sudoku, IntMap);
                    if (sudoku.Count >= 81) return sudoku;
                    sudoku[i, j] = 0;
                }
            }

            return sudoku;
        }
        public static Sudoku GenerateValidSudoku()
        { // 生成一个有解的数独矩阵
            Sudoku sudoku = new Sudoku();

            while (sudoku.Count < 81)
            { // 如果无解就再生成一遍，囧

                int[] IntMap = GenerateTenIntMap();
                int TT = 0;
                for (int i = 1; i <= 3; ++i)
                {
                    for (int j = 1; j <= 3; ++j)
                    {
                        sudoku[i, j] = IntMap[TT++];
                    }
                }
                TT = 0; IntMap = GenerateTenIntMap();
                for (int i = 4; i <= 6; ++i)
                {
                    for (int j = 4; j <= 6; ++j)
                    {
                        sudoku[i, j] = IntMap[TT++];
                    }
                }
                TT = 0; IntMap = GenerateTenIntMap();
                for (int i = 7; i <= 9; ++i)
                {
                    for (int j = 7; j <= 9; ++j)
                    {
                        sudoku[i, j] = IntMap[TT++];
                    }
                }
                // 先初始化三个互不相关的子矩阵

                sudoku = InternalGenerateSudoku(1, 1, sudoku, IntMap);
                // 然后调用DFS进行求解
            }

            return sudoku;
        }
        public static Sudoku GenerateSudoku(int WithNElements)
        {
            Sudoku sudoku = GenerateValidSudoku();
            int CountNeedToDelete = 81 - WithNElements;
            if (CountNeedToDelete >= 0)
            {
                Random rn = new Random();
                List<Tuple<int, int>> ListCoordinate = new List<Tuple<int, int>>();
                for (int i = 1; i <= 9; ++i)
                {
                    for (int j = 1; j <= 9; ++j)
                    {
                        ListCoordinate.Add(new Tuple<int, int>(i,j));
                    }
                }
                while (CountNeedToDelete > 0)
                {
                    int id = rn.Next(0, ListCoordinate.Count);
                    sudoku[ListCoordinate[id].Item1, ListCoordinate[id].Item2] = 0;
                    ListCoordinate.Remove(ListCoordinate[id]);
                    --CountNeedToDelete;
                }
            }
            else
            {
                throw new Exception("无法生成合法数独。");
            }

            return sudoku;
        }
    }
}
