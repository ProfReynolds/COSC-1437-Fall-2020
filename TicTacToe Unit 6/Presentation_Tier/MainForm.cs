using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

/*
 * ProfReynolds
 */

namespace Presentation_Tier
{
    public partial class MainForm : Form
    {
        private Middle_Tier.TicTacToeGame _ticTacToeGame = new Middle_Tier.TicTacToeGame();

        public MainForm()
        {
            InitializeComponent();
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
                var btn = item as Button;
                if (btn != null)
                {
                    btn.Text = "?";
                }

                //if (item is Button btn)
                //{
                //    btn.Text = "?";
                //}
            }
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("btnGoComputer", "Button Click");

            _ticTacToeGame.AutoPlayComputer();

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("The Winner!");
            }
        }

        private void btnCell00_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell00", "Button Click");
        }

        private void btnCell01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnCell01", "Button Click");
        }
    }
}
