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
            var newForm = new AboutBox();
            newForm.Show();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            // as the content changes, this event will trigger as each character changes

            var PlayerNameIsValid = (txtPlayerName.Text.Length >= 3);

            btnStartNewGame.Enabled = PlayerNameIsValid;
            btnGoComputer.Enabled = PlayerNameIsValid;
            //btnCell00.Enabled = PlayerNameIsValid;
            //btnCell01.Enabled = PlayerNameIsValid;
            //btnCell02.Enabled = PlayerNameIsValid;
            //btnCell10.Enabled = PlayerNameIsValid;
            //btnCell11.Enabled = PlayerNameIsValid;
            //btnCell12.Enabled = PlayerNameIsValid;
            //btnCell20.Enabled = PlayerNameIsValid;
            //btnCell21.Enabled = PlayerNameIsValid;
            //btnCell22.Enabled = PlayerNameIsValid;
            panel1.Enabled = PlayerNameIsValid;
        }

        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            // when the focus leaves the text box, this event is triggered
        }

    }
}
