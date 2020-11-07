using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBrain;

/*
 * Prof Reynolds
 */

namespace UserInterfaceGraphics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// a local field (variable) to hold the connection / link to the DLL’s class.
        /// This line is said to instantiate the class.
        /// </summary>
        private TicTacToeGame _ticTacToeGame = new TicTacToeGame();

        private void MainForm_Load(object sender, EventArgs e)
        {
            _ticTacToeGame.MarkerChanged += this.MarkerChangedHandler;
            EnableControls(false);
        }

        void EnableControls(bool setControlsEnabled)
        {
            foreach (var control in this.Controls)
            {
                switch (control)
                {
                    case Button btn when (btn.Name != "btnClose" && btn.Name != "btnAbout"):
                        btn.Enabled = setControlsEnabled;
                        break;

                    case TableLayoutPanel pnl:
                        pnl.Enabled = setControlsEnabled;
                        break;

                    default:
                        break;
                }
            }
        }

        void EvaluateAndAnnounceWinner()
        {
            if (_ticTacToeGame.EvaluateBoard())
            {
                MessageBox.Show(
                    $"The winner is {_ticTacToeGame.IdentifyWinner()}",
                    "Tic Tac Toe Winner",
                    MessageBoxButtons.OK);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var aboutBox = new AboutBoxTicTacToe();
            //aboutBox.Show();
            aboutBox.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            _ticTacToeGame.ResetGrid();

            foreach (var item in this.tableLayoutPanel1.Controls)
            {
                if (item is GameCell gameCell)
                {
                    gameCell.CellOwner = CellOwners.Open;
                }
            }
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner == CellOwners.Open)
            {
                _ticTacToeGame.AutoPlayComputer();
                EvaluateAndAnnounceWinner();
            }
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            var nameIsValid = (txtPlayerName.TextLength >= 2);
            EnableControls(nameIsValid);
        }

        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            _ticTacToeGame.PlayerName = txtPlayerName.Text;
        }

        private void MarkerChangedHandler(object sender, TheBrain.TicTacToeGame.MarkerChangedArgs e)
        {
            foreach (var item in this.tableLayoutPanel1.Controls)
            {
                if (!(item is GameCell gameCell)) continue;
                if ((gameCell.CellRowNo != e.RowID) || (gameCell.CellColNo != e.ColID)) continue;
                gameCell.CellOwner = e.CellOwner;
            }
        }

        private void EmojiMasterClick(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != CellOwners.Open) return;
            var gameCell = sender as GameCell;
            if (gameCell == null) return;
            _ticTacToeGame.PlaceMarker(gameCell.CellRowNo, gameCell.CellColNo, CellOwners.Human);
            EvaluateAndAnnounceWinner();
        }
    }
}

/*
 * Prof Reynolds
 */
