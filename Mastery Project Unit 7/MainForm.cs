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
using System.Security.Cryptography;
using System.Diagnostics;
using CoreLibrary;
using System.Text.RegularExpressions;

/*
 * Trey Gamble
 */

namespace Main_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * ProfReynolds
             * double-click Properties; select Settings, add new parameter PreviousFilePath
             */
            toolStripStatusLabel1.Text = Properties.Settings.Default.PreviousFilePath;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

            private void btnOpenFile_Click(object sender, EventArgs e)
            {
                var openFileDialog = new OpenFileDialog
                {
                    Filter = @"Comma Separated Values|*.csv|Text File|*.txt|All Files|*.*",
                    Title = @"Select a file, preferably a plain text file",
                    FileName = Properties.Settings.Default.PreviousFilePath
                };

                var dialogResult = openFileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.SafeFileName;

                    toolStripStatusLabel1.Text = openFileDialog.FileName;

                    Properties.Settings.Default.PreviousFilePath = openFileDialog.FileName;
                    Properties.Settings.Default.Save();

                using (StreamReader sr = File.OpenText(openFileDialog.FileName))
                    {
                    //I do not understand what I am doing wrong here, ReadEncrypt is a Function, no?
                    string fileContent = ReadEncrypt(openFileDialog.FileName);
                        
                        var parsedArrayOfStrings:string[] = Regex.Split(input: fileContent, pattern: "\n");

                        lbFileOutput.Items.AddRange(parsedArrayOfStrings);
                    }
                }
            }

        private void btnWriteEF_Click(object sender, EventArgs e)
        {
            /// <summary> 
            /// Encrypt FileStream 
            /// </summary> 
            /// <param name="outputFilePath">full path to the output file</param> 
            /// <param name="msg">text to output</param> 
             static void WriteEncrypt(string outputFilePath, string msg)
             {
                FileStream outputFileStream =
                    new FileStream(outputFilePath,
                        FileMode.Create,
                        FileAccess.Write);


                Debug.WriteLine($"Property 'Name' : {outputFileStream.Name}");
                Debug.WriteLine($"Property 'CanRead' : {outputFileStream.CanRead}");
                // (1) Create Data Encryption Standard (DES) object.
                DESCryptoServiceProvider crypt = new DESCryptoServiceProvider() 
                {
                    // (2) Create a key and Initialization Vector - requires 8 bytes
                    KeySize = 64,
                    Key = new byte[] { 07, 30, 20, 01, 04, 20, 69, 99 },
                    IV = new byte[] { 07, 30, 20, 01, 04, 20, 69, 99 }
                };
                // old crypt.Key = new byte[] { 71, 72, 83, 84, 85, 96, 97, 78 };
                // old crypt.IV = new byte[] { 71, 72, 83, 84, 85, 96, 97, 78 };
                // (3) Create CryptoStream stream object
                CryptoStream cs =
                     new CryptoStream(outputFileStream,
                        crypt.CreateEncryptor(),
                         CryptoStreamMode.Write);
                // (4) Create StreamWriter using CryptoStream
                StreamWriter sw = new StreamWriter(cs);
                sw.Write(msg);
                sw.Close();
                cs.Close();
            }
        }

        private void btnReadEF_Click(object sender, EventArgs e)
        {
            /// <summary> 
            /// Read and Decrypt a file stream. 
            /// </summary> 
            /// <param name="inputFilePath">input file path name</param> 
            /// <returns></returns> private static string ReadEncrypt(string inputFilePath)
            static void ReadEncrypt(string outputFilePath, string msg)
            {
                var openFileDialog = new OpenFileDialog();

                var inputFilePath = openFileDialog.FileName;
                FileStream sourceFileStream =
                    new FileStream(inputFilePath, FileMode.Open, FileAccess.Read);

                Debug.WriteLine($"Property 'Name' : {sourceFileStream.Name}");
                Debug.WriteLine($"Property 'CanRead' : {sourceFileStream.CanRead}");
                // (1) Create Data Encryption Standard (DES) object.
                DESCryptoServiceProvider crypt = new DESCryptoServiceProvider();
                // (2) Create a key and Initialization Vector
                crypt.Key = new byte[] { 71, 72, 83, 84, 85, 96, 97, 78 };
                crypt.IV = new byte[] { 71, 72, 83, 84, 85, 96, 97, 78 };
                // (3) Create CryptoStream stream object
                CryptoStream cs =
                     new CryptoStream(sourceFileStream,
                        crypt.CreateDecryptor(),
                         CryptoStreamMode.Read);
                // (4) Create StreamReader using CryptoStream
                StreamReader sr = new StreamReader(cs);
                string msg = sr.ReadToEnd();
                sr.Close();
                cs.Close();

                Debug.WriteLine($"Property 'EndOfStream' : {sr.EndOfStream}");

                string sourceFileContent = sr.ReadToEnd();

                Debug.WriteLine($"Property 'EndOfStream' : {sr.EndOfStream}");
                Debug.WriteLine(message: sourceFileContent.Left(25));

                return msg;
            }
        }
    }
}
