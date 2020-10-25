using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

/*
 * Prof Reynolds
 */

namespace Main_Application
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

        //private void btnOpenCsvFile_Click(object sender, EventArgs e)
        //{
        //    // Displays an OpenFileDialog so the user may select a CSV file
        //    var openFileDialog = new OpenFileDialog
        //    {
        //        Filter = @"Comma Separated Values|*.csv|Text File|*.txt",
        //        Title = @"Select the Hundred Names database"
        //    };

        //    // show the dialog
        //    // if the user clicked OK, open it
        //    var dialogResult = openFileDialog.ShowDialog();
        //    if (dialogResult == DialogResult.OK)
        //    {
        //        MessageBox.Show(
        //            openFileDialog.SafeFileName,
        //            @"You Selected", MessageBoxButtons.OK,
        //            MessageBoxIcon.Information);
        //    }
        //}

    }
}
