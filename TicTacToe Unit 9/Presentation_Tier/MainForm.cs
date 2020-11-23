using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using CoreLibrary;
using TicTacToe_Interfaces;

/*
 * ProfReynolds
 */

namespace Presentation_Tier
{
    public partial class MainForm : Form
    {
        private Middle_Tier.TicTacToeGame _ticTacToeGame = new Middle_Tier.TicTacToeGame();

        /*
        * ProfReynolds - 2021
        * I rearranged the methods. Does not change the operation but makes it easier to follow:
        * 1) constructor (MainForm) and never put anything other than InitializeComponent in the method
        * 2) form events especially the load event
        * 3) control events especially the click events
        * 4) other event handlers such as the _ticTacToeGame.CellOwnerChanged
        * 5) misc necessary methods (since very, very little implementation belongs in the UI, this should be limited)
        */

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // unit #9
            _ticTacToeGame.CellOwnerChanged += this.CellOwnerChangedHandler;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var newForm = new AboutBox();
            newForm.Show();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            // as the content changes, this event will trigger as each character changes

            var playerNameIsValid = (txtPlayerName.Text.Length >= 3);

            btnStartNewGame.Enabled = playerNameIsValid;
            btnGoComputer.Enabled = playerNameIsValid;
            //btnCell00.Enabled = PlayerNameIsValid;
            //btnCell01.Enabled = PlayerNameIsValid;
            //btnCell02.Enabled = PlayerNameIsValid;
            //btnCell10.Enabled = PlayerNameIsValid;
            //btnCell11.Enabled = PlayerNameIsValid;
            //btnCell12.Enabled = PlayerNameIsValid;
            //btnCell20.Enabled = PlayerNameIsValid;
            //btnCell21.Enabled = PlayerNameIsValid;
            //btnCell22.Enabled = PlayerNameIsValid;
            panel1.Enabled = playerNameIsValid;
        }

        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            // when the focus leaves the text box, this event is triggered
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("btnStartNewGame","Button Click");

            _ticTacToeGame.ResetGrid();

            foreach (var item in panel1.Controls)
            {
                //var btn = item as Button;
                //if (btn != null)
                //{
                //    btn.Text = "?";
                //}

                if (item is Button btn)
                {
                    btn.Text = "?";
                }
            }
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("btnGoComputer", "Button Click");

            // unit #8
            if (_ticTacToeGame.Winner != CellOwners.Open) return;

            _ticTacToeGame.AutoPlayComputer();

            if (_ticTacToeGame.CheckForWinner())
            {
                // 2021 MessageBox.Show("The Winner!");
                MessageBox.Show("Computer","The Winner!"); // 2021
            }
        }

        /*
         * removed in unit #8
         *
        private void btnCell00_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell00", "Button Click");
        }

        private void btnCell01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell01", "Button Click");
        }
         *
         */

        private void btnCellxx_Click(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != CellOwners.Open) return;

            var btn = sender as Button;
            
            var rowID = btn.Name.Substring(7, 1).ToInt();
            
            var colID = btn.Name.Substring(8, 1).ToInt();
            
            Debug.WriteLine($"Button click: row={rowID} col={colID}");

            _ticTacToeGame.AssignCellOwner(rowID,colID,CellOwners.Human);
            btn.Text = "X";
            
            if (_ticTacToeGame.CheckForWinner())
            {
                // 2021 MessageBox.Show("The Winner!");
                MessageBox.Show(_ticTacToeGame.PlayerName, "The Winner!"); // 2021
            }
        }

        private void CellOwnerChangedHandler(object sender, Middle_Tier.TicTacToeGame.CellOwnerChangedArgs e)
        {
            // unit #9
            var buttonName = $"btnCell{e.RowID}{e.ColID}";
            foreach (var control in panel1.Controls)
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
