#region Info
/* author : Hongju Shin
 * ID:  100844220
 * Date: 27 Mar 2022
 * Subject: Lab5
 * Purpose: simple text editor project
 */
#endregion

#region Using statements
using System;
using System.Windows.Forms;
using System.IO;
#endregion


namespace LAB5
{
    public partial class Form1 : Form
    {
        #region initialization 

        String path = "";              // variable path of the file
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


        #region Tool strip menu events
        /// <summary>
        /// new file open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Clear();             // clear the text box
            path = "";                   // path to empty 
        }

        /// <summary>
        /// Open file using the open file method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        /// <summary>
        /// save as a new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        /// <summary>
        /// Save the text, save to a new file if there is no saved file for the current document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == string.Empty)         // if there is no saved 
            { SaveFile(); }                   // the same as "save as"
            else                              // or, save to the current file
            {
                StreamWriter sw = new StreamWriter(path);
                sw.Write(txtMain.Text);
                sw.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMain.SelectedText);
            SendKeys.Send("{DELETE}");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMain.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Paste(Clipboard.GetText());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About newForm = new About();
            newForm.ShowDialog();
            new About().ShowDialog();
        }


        #endregion




        #region Tool strip icons events
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem.PerformClick();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem.PerformClick();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.PerformClick();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.PerformClick();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem.PerformClick();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem.PerformClick();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            aboutToolStripMenuItem.PerformClick();
        }
        #endregion


        #region Custom methods
        /// <summary>
        /// Open file method
        /// </summary>
        private void OpenFile()
        {
            DialogResult openResult = openFileDialog1.ShowDialog();
            if (openResult == DialogResult.OK)                  // open file dialog 
            {
                path = openFileDialog1.FileName;                // open file path
                StreamReader fileOpen = new StreamReader(path); // Using StreamWriter class
                String contents = fileOpen.ReadToEnd();         // open file and read
                fileOpen.Close();
                txtMain.Text = contents;                        // text box write
            }
        }

        /// <summary>
        /// Save file method
        /// </summary>
        private void SaveFile()
        {
            DialogResult saveResult = saveFileDialog1.ShowDialog();
            if (saveResult == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;            // saving file path
                StreamWriter sw = new StreamWriter(path);   // Using StreamWriter class
                sw.Write(txtMain.Text);                     // save file
                sw.Close();
            }
        }





        #endregion


    }
}
 