using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SudokuGame
{
    public partial class CustomizeForm : Form
    {
        private int CountRemains = 0;
        private User user;
        public CustomizeForm(User InitUser)
        {
            InitializeComponent();
            user = InitUser;
        }

        private void TrackBarSudokuRemains_Scroll(object sender, EventArgs e)
        {
            CountRemains = TrackBarSudokuRemains.Value;
            if (TextSudokuRemains.Text != CountRemains.ToString())
            {
                TextSudokuRemains.Text = CountRemains.ToString();
            } 
        }

        private void TextSudokuRemains_TextChanged(object sender, EventArgs e)
        {
            CountRemains = Convert.ToInt32(TextSudokuRemains.Text);
            if (TrackBarSudokuRemains.Value != CountRemains)
            {
                TrackBarSudokuRemains.Value = CountRemains;
            }
        }

        private void ButtonGenerateSudoku_Click(object sender, EventArgs e)
        {
            Sudoku sudoku = CommonUtils.GenerateSudoku(81 - CountRemains);
            Form GmForm = new GameForm(sudoku, user, false, user.Name + ".customize.sudoku");
            GmForm.ShowDialog();
        }
    }
}
