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
    public partial class SelectForm : Form
    {
        private User user;
        public SelectForm(User InitUser)
        {
            InitializeComponent();
            user = InitUser;
        }

        private string[] sudokuStrings = new[] 
            { "846975213752413968391628574973846125418752630265391487129537846634189752587264391", 
              "285679143967431852314852679643285791152067438879314520431796285528143907796528314",
              "781234596423596178659178034230781965965023817170609042340965781596817403817340659",
              "352487600974630508816009437061352789508974163793810245047098350185263074209740016",
              "007810469040025381100469725804257613015000870762138594083691257571382946620074108",
              "507020498009148706604705023348517062176239845952604371000862517865071200720000680",
              "008740093070895240409100850740068912005301684800429730934217508002080371087050420",
              "384076002025813000600052070962300517038005069457691238000267004040130025270048000",
              "057800010004791020160500078006250001500384096400160532000008257095000004000470069",
              "050003016204081000168000000020900081001004009095100000800312900000800030302009108"
            };

        private Button[] Buttons = new Button[10];

        private void ButtonOnClick(object sender, EventArgs e)
        {
            Sudoku sudoku = new Sudoku(sudokuStrings[int.Parse(((Button)sender).Name)]);
            Form GmForm = new GameForm(sudoku, user, false, user.LastArcadeGameSavePath());
            GmForm.ShowDialog();
        }
        private void SelectForm_Load(object sender, EventArgs e)
        {
            int TT = 0;
            for (int i = 0; i < 2; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    Buttons[TT] = new Button();
                    TbLayoutSelect.Controls.Add(Buttons[TT]);
                    Buttons[TT].Text = (TT + 1).ToString();
                    Buttons[TT].Name = TT.ToString();
                    Buttons[TT].Dock = DockStyle.Fill;
                    Buttons[TT].Click += new EventHandler(ButtonOnClick);
                    ++TT;
                }
            }
        }
    }
}
