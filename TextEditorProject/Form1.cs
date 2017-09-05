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

namespace TextEditorProject
{
    public partial class Form1 : Form
    {
        public string FileSource { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //Discovered how to anchor all four sides and ended up not needing this.
            //not sure why, but removing the whole thing makes the form go buggy
        }
        //open file menu item
        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the file dialog from drop down menu item 'open'
            openFileDialog1.ShowDialog();
            //filter to allow only text files
            openFileDialog1.Filter = "Text (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileSource = openFileDialog1.FileName;
                    string file_content = File.ReadAllText(FileSource);
                    RTBFileReader.Text = file_content;
                    Form1.ActiveForm.Text = String.Format("Simple Text Editor: {0}", FileSource);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File could not be opened due to error {0}", ex.Message);
                }
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileSource != null)
            {
                try
                {
                    //write file to save
                    File.WriteAllText(FileSource, RTBFileReader.Text);
                    MessageBox.Show("File has been saved!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            //if no file source, save as
            else
            {
                MessageBox.Show("Where should I save this?");
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }
        //save as menu item
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the save file dailog from drop down menu item 'save as'
            SaveFileDialog savefile = new SaveFileDialog();
            //allows save as text files
            savefile.Filter = "Text (*.txt)|*.txt";
            savefile.Title = "Save your work!";
            if (System.Windows.Forms.DialogResult.OK == savefile.ShowDialog())
            {
                try
                {
                    FileSource = savefile.FileName;
                    File.WriteAllText(FileSource, RTBFileReader.Text);
                    MessageBox.Show("File saved to {0}", FileSource);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

        }
        private void WordWrapToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            switch (WordWrapToolStripMenuItem.Checked)
            {
                //when not checked, word wrap is not on, scroll in both directions possible
                case false:
                    WordWrapToolStripMenuItem.Checked = false;
                    RTBFileReader.WordWrap = false;
                    break;
                //when checked, word wrap is on, vertical scroll only
                case true:
                    WordWrapToolStripMenuItem.Checked = true;
                    RTBFileReader.WordWrap = true;
                    break;
            }
        }
        //switches for color of text box
        private void PlumToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            switch (PlumToolStripMenuItem.Checked)
            {
                case true://Plum option checked
                    RTBFileReader.BackColor = Color.MediumPurple;
                    RTBFileReader.ForeColor = Color.Gainsboro;
                    menuStrip1.BackColor = Color.Purple;
                    menuStrip1.ForeColor = Color.Gainsboro;
                    Form1.ActiveForm.BackColor = Color.Plum;
                    DefaultToolStripMenuItem.Checked = false;
                    NightTimeToolStripMenuItem.Checked = false;
                    break;
                case false://If user unchecks option, default to default view
                    DefaultToolStripMenuItem.Checked = true;
                    break;
            }
        }
        private void NightTimeToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            switch (NightTimeToolStripMenuItem.Checked)
            {
                case true://'night' option checked
                    RTBFileReader.BackColor = Color.Navy;
                    RTBFileReader.ForeColor = Color.GhostWhite;
                    menuStrip1.BackColor = Color.DarkSlateBlue;
                    menuStrip1.ForeColor = Color.GhostWhite;
                    Form1.ActiveForm.BackColor = Color.RoyalBlue;
                    DefaultToolStripMenuItem.Checked = false;
                    PlumToolStripMenuItem.Checked = false;
                    break;
                case false://If user unchecks option, default to default
                    DefaultToolStripMenuItem.Checked = true;
                    break;
            }
        }
        private void DefaultToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            switch (DefaultToolStripMenuItem.Checked)
            {
                case true://if default is on (at start), checked, or other options are un-checked
                    RTBFileReader.BackColor = Color.White;
                    RTBFileReader.ForeColor = Color.Black;
                    menuStrip1.BackColor = SystemColors.Control;
                    menuStrip1.ForeColor = Color.Black;
                    Form1.ActiveForm.BackColor = SystemColors.Control;
                    PlumToolStripMenuItem.Checked = false;
                    NightTimeToolStripMenuItem.Checked = false;
                    break;
            }
        }
        //Program info pop-up message box
        private void ProgramInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //simple message about the program, author, and classname
            MessageBox.Show("A simple text viewer, capable of opening, editing, and saving plain text documents.\nThere are several options for changing the appearance of the program.\nProgram created by Emily Gleason.\nVersion 1.0\nWake Tech Coding Boot Camp.");
        }
        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //not used
        }
        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //not used
        }
        //font face options
        private void TimesNewRomanToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            //can't seem to get the fonts to do what i want
        }
        //font size options
        private void FontSize8_CheckStateChanged_1(object sender, EventArgs e)
        {
           //another thing I scrapped but couln't figure out how to delete
        }

        private void FontSizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           //this font size thing is really tripping me up, man
        }
        //open a font dialog to save me a headache and actually change things
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = RTBFileReader.Font;
            fontDialog1.Color = RTBFileReader.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
                RTBFileReader.Font = fontDialog1.Font;
                RTBFileReader.ForeColor = fontDialog1.Color;
        }
        //when text boxes for find and find/replace tools are entered, text disappears.
        //This doesn't seem to be working and I can't quite figure out why. But, the find and find/replace functions work!
        private void TBFindMenuBox_Click(object sender, EventArgs e)
        {
            if (TBFindMenuBox.Text.Trim() != "" || TBFindMenuBox.Text != null)
            {
                TBFindMenuBox.Text = "";
            }
        }
        private void FindForReplaceTB_Click(object sender, EventArgs e)
        {
            if (FindForReplaceTB.Text.Trim() != "" || FindForReplaceTB.Text != null)
            {
                FindForReplaceTB.Text = "";
            }
        }
        private void ReplaceWithTB_Click(object sender, EventArgs e)
        {
            if (ReplaceWithTB.Text.Trim() != "" || ReplaceWithTB.Text != null)
            {
                ReplaceWithTB.Text = "";
            }
        }
        //find tool element
        private void FindTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String FindIn = TBFindMenuBox.Text;
            int FoundAt = RTBFileReader.Text.IndexOf(FindIn);
            if (TBFindMenuBox.Text != String.Empty && FoundAt >= 0)
            {
                RTBFileReader.Focus();
                RTBFileReader.Select(FoundAt, 0);
            }
            if (TBFindMenuBox.Text == String.Empty)
            {
                MessageBox.Show("You must enter some text to be found.");
            }
            if (TBFindMenuBox.Text != String.Empty && FoundAt <0)
            {
                MessageBox.Show("Text not found in document. \nFind function is case sensitive.");
            }
        }
        //find and replace tool element
        private void ReplaceNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String FindFor = FindForReplaceTB.Text;
            int FoundAt = RTBFileReader.Text.IndexOf(FindFor);
            String ReplaceWith = ReplaceWithTB.Text;
            String PullText = RTBFileReader.Text;
            if (FindForReplaceTB.Text != String.Empty && PullText.Contains(FindFor))
            {
                String ReplacedText = PullText.Replace(FindFor, ReplaceWith);
                RTBFileReader.Text = ReplacedText;
                RTBFileReader.Focus();
            }
            if (FindForReplaceTB.Text == String.Empty)
            {
                MessageBox.Show("You must enter some text to be replaced.");
            }
            if (ReplaceWithTB.Text == String.Empty && FoundAt >= 0)
            {
                MessageBox.Show("You must enter some new text.");
            }
            if (FindForReplaceTB.Text != String.Empty && FoundAt <0)
            {
                MessageBox.Show("Text not found in document. \nFind and Replace function is case sensitive.");
            }
        }
        

    }
}
