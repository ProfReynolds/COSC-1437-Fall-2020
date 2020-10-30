using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileFialog so the user may select a CSV file
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Comma Separated Values|*.csv|Text File|*.txt",
                Title = @"Select the HundredNames database"
            };

            // show the dialog
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show(
                    openFileDialog.SafeFileName,
                    @"Yo Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtFileName.Text = openFileDialog.SafeFileName;

                toolStripStatusLabel1.Text = openFileDialog.FileName;

                using (StreamReader sr = File.OpenText(openFileDialog.FileName))
                {
                    var oneLineOfText = "";
                    while ((oneLineOfText = sr.ReadLine()) != null)
                    {
                        lbFileOutput.Items.Add(oneLineOfText);
                    }
                }

            }
        }
    }
}
