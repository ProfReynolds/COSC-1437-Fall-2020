using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonFramework.Core;
using TheBrain;


/*
 * ProfReynolds
 */

namespace UserInterface
{
    [SuppressMessage("ReSharper", "LocalizableElement")]
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var aboutBox = new AboutBoxTicTacToe();
            //aboutBox.Show();
            aboutBox.ShowDialog();
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

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            _ticTacToeGame.ResetGrid();

            foreach (var button in pnlButtons.Controls)
            {
                if (button is Button btn)
                {
                    btn.Text = "?";
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

        private void btnSquare_Common_Click(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != CellOwners.Open) return;

            if (sender is Button btn)
            {
                if(btn.Name.Length == 11 &&
                   btn.Name.StartsWith("btnSquare"))
                {
                    var row = btn.Name.Substring(9, 1).ToInt32(-1);
                    var col = btn.Name.Substring(10, 1).ToInt32(-1);
                    _ticTacToeGame.PlaceMarker(row, col, CellOwners.Human);

                    // btn.Text = "X";

                    EvaluateAndAnnounceWinner();
                }
            }
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

                    case Panel pnl:
                        pnl.Enabled = setControlsEnabled;
                        break;

                    default:
                        break;
                }
            }
        }

        private void MarkerChangedHandler(object sender, TheBrain.TicTacToeGame.MarkerChangedArgs e)
        {
            var buttonName = $"btnSquare{e.RowID}{e.ColID}";
            foreach (var control in this.pnlButtons.Controls)
            {
                if (control is Button button)
                {
                    if (button.Name == buttonName)
                    {
                        switch (e.CellOwner)
                        {
                            case CellOwners.Error:
                                button.Text = "#";
                                break;

                            case CellOwners.Open:
                                button.Text = "?";
                                break;

                            case CellOwners.Human:
                                button.Text = "X";
                                break;

                            case CellOwners.Computer:
                                button.Text = "O";
                                break;

                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                }
            }
        }

    }
}
