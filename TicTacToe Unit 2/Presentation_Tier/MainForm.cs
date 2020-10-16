using System;
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
    }
}
