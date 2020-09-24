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

namespace UI_Layer_CSharp
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

            var PlayerNameIsVaid = (txtPlayerName.Text.Length >= 3);

            btnStartNewGame.Enabled = PlayerNameIsVaid;
            btnGoComputer.Enabled = PlayerNameIsVaid;
            //btnCell00.Enabled = PlayerNameIsVaid;
            //btnCell01.Enabled = PlayerNameIsVaid;
            //btnCell02.Enabled = PlayerNameIsVaid;
            //btnCell10.Enabled = PlayerNameIsVaid;
            //btnCell11.Enabled = PlayerNameIsVaid;
            //btnCell12.Enabled = PlayerNameIsVaid;
            //btnCell20.Enabled = PlayerNameIsVaid;
            //btnCell21.Enabled = PlayerNameIsVaid;
            //btnCell22.Enabled = PlayerNameIsVaid;
            panel1.Enabled = PlayerNameIsVaid;
        }

        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            // when the focus leaves the text box, this event is triggered
        }

    }
}
