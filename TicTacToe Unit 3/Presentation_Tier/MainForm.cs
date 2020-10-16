using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * ProfReynolds
 */

namespace Presentation_Tier
{
    public partial class MainForm : Form
    {
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
            AboutBox newForm = new AboutBox();
            newForm.Show();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            // as the content changes, this event will trigger as each character changes

            bool PlayerNameIsVaid = (txtPlayerName.Text.Length >= 3);

            btnStartNewGame.Enabled = PlayerNameIsVaid;
            btnGoComputer.Enabled = PlayerNameIsVaid;
            btnCell00.Enabled = PlayerNameIsVaid;
            btnCell01.Enabled = PlayerNameIsVaid;
            btnCell02.Enabled = PlayerNameIsVaid;
            btnCell10.Enabled = PlayerNameIsVaid;
            btnCell11.Enabled = PlayerNameIsVaid;
            btnCell12.Enabled = PlayerNameIsVaid;
            btnCell20.Enabled = PlayerNameIsVaid;
            btnCell21.Enabled = PlayerNameIsVaid;
            btnCell22.Enabled = PlayerNameIsVaid;
        }

        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            // when the focus leaves the text box, this event is triggered
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {

        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {

        }

        private void btnCell00_Click(object sender, EventArgs e)
        {

        }

        private void btnCell01_Click(object sender, EventArgs e)
        {

        }

        private void btnCell02_Click(object sender, EventArgs e)
        {

        }

        private void btnCell10_Click(object sender, EventArgs e)
        {

        }

        private void btnCell11_Click(object sender, EventArgs e)
        {

        }

        private void btnCell12_Click(object sender, EventArgs e)
        {

        }

        private void btnCell20_Click(object sender, EventArgs e)
        {

        }

        private void btnCell21_Click(object sender, EventArgs e)
        {

        }

        private void btnCell22_Click(object sender, EventArgs e)
        {

        }
    }
}
