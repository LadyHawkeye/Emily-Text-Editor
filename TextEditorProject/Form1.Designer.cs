namespace TextEditorProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NightTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.RTBFileReader = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.TBFindMenuBox = new System.Windows.Forms.ToolStripTextBox();
            this.FindTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindForReplaceTB = new System.Windows.Forms.ToolStripTextBox();
            this.ReplaceWithTB = new System.Windows.Forms.ToolStripTextBox();
            this.ReplaceNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.viewToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(808, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.FindToolStripMenuItem,
            this.findAndReplaceToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.viewToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // FindToolStripMenuItem
            // 
            this.FindToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBFindMenuBox,
            this.FindTextToolStripMenuItem});
            this.FindToolStripMenuItem.Name = "FindToolStripMenuItem";
            this.FindToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.FindToolStripMenuItem.Text = "Find";
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindForReplaceTB,
            this.ReplaceWithTB,
            this.ReplaceNowToolStripMenuItem});
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.findAndReplaceToolStripMenuItem.Text = "Find and Replace";
            this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowThemeToolStripMenuItem,
            this.WordWrapToolStripMenuItem});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem1.Text = "View";
            // 
            // windowThemeToolStripMenuItem
            // 
            this.windowThemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefaultToolStripMenuItem,
            this.PlumToolStripMenuItem,
            this.NightTimeToolStripMenuItem});
            this.windowThemeToolStripMenuItem.Name = "windowThemeToolStripMenuItem";
            this.windowThemeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.windowThemeToolStripMenuItem.Text = "Window Theme";
            // 
            // DefaultToolStripMenuItem
            // 
            this.DefaultToolStripMenuItem.Checked = true;
            this.DefaultToolStripMenuItem.CheckOnClick = true;
            this.DefaultToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem";
            this.DefaultToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.DefaultToolStripMenuItem.Text = "Default";
            this.DefaultToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.DefaultToolStripMenuItem_CheckStateChanged);
            // 
            // PlumToolStripMenuItem
            // 
            this.PlumToolStripMenuItem.CheckOnClick = true;
            this.PlumToolStripMenuItem.Name = "PlumToolStripMenuItem";
            this.PlumToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.PlumToolStripMenuItem.Text = "Plum";
            this.PlumToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.PlumToolStripMenuItem_CheckStateChanged);
            // 
            // NightTimeToolStripMenuItem
            // 
            this.NightTimeToolStripMenuItem.CheckOnClick = true;
            this.NightTimeToolStripMenuItem.Name = "NightTimeToolStripMenuItem";
            this.NightTimeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.NightTimeToolStripMenuItem.Text = "Night Time";
            this.NightTimeToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.NightTimeToolStripMenuItem_CheckStateChanged);
            // 
            // WordWrapToolStripMenuItem
            // 
            this.WordWrapToolStripMenuItem.Checked = true;
            this.WordWrapToolStripMenuItem.CheckOnClick = true;
            this.WordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem";
            this.WordWrapToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.WordWrapToolStripMenuItem.Text = "Word Wrap";
            this.WordWrapToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.WordWrapToolStripMenuItem_CheckStateChanged);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramInformationToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ProgramInformationToolStripMenuItem
            // 
            this.ProgramInformationToolStripMenuItem.Name = "ProgramInformationToolStripMenuItem";
            this.ProgramInformationToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ProgramInformationToolStripMenuItem.Text = "Program Information";
            this.ProgramInformationToolStripMenuItem.Click += new System.EventHandler(this.ProgramInformationToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RTBFileReader
            // 
            this.RTBFileReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBFileReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBFileReader.Location = new System.Drawing.Point(0, 42);
            this.RTBFileReader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RTBFileReader.Name = "RTBFileReader";
            this.RTBFileReader.Size = new System.Drawing.Size(806, 407);
            this.RTBFileReader.TabIndex = 2;
            this.RTBFileReader.Text = "";
            // 
            // TBFindMenuBox
            // 
            this.TBFindMenuBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBFindMenuBox.Name = "TBFindMenuBox";
            this.TBFindMenuBox.Size = new System.Drawing.Size(100, 23);
            this.TBFindMenuBox.Text = "Enter Text Here";
            this.TBFindMenuBox.Enter += new System.EventHandler(this.TBFindMenuBox_Click);
            // 
            // FindTextToolStripMenuItem
            // 
            this.FindTextToolStripMenuItem.Name = "FindTextToolStripMenuItem";
            this.FindTextToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.FindTextToolStripMenuItem.Text = "Find Text";
            this.FindTextToolStripMenuItem.Click += new System.EventHandler(this.FindTextToolStripMenuItem_Click);
            // 
            // FindForReplaceTB
            // 
            this.FindForReplaceTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindForReplaceTB.Name = "FindForReplaceTB";
            this.FindForReplaceTB.Size = new System.Drawing.Size(100, 23);
            this.FindForReplaceTB.Text = "Text To Find";
            // 
            // ReplaceWithTB
            // 
            this.ReplaceWithTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReplaceWithTB.Name = "ReplaceWithTB";
            this.ReplaceWithTB.Size = new System.Drawing.Size(100, 23);
            this.ReplaceWithTB.Text = "Text To Replace";
            // 
            // ReplaceNowToolStripMenuItem
            // 
            this.ReplaceNowToolStripMenuItem.Name = "ReplaceNowToolStripMenuItem";
            this.ReplaceNowToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ReplaceNowToolStripMenuItem.Text = "Replace Now";
            this.ReplaceNowToolStripMenuItem.Click += new System.EventHandler(this.ReplaceNowToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 449);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.RTBFileReader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Simple Text Editor";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem windowThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NightTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramInformationToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox RTBFileReader;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripTextBox TBFindMenuBox;
        private System.Windows.Forms.ToolStripMenuItem FindTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox FindForReplaceTB;
        private System.Windows.Forms.ToolStripTextBox ReplaceWithTB;
        private System.Windows.Forms.ToolStripMenuItem ReplaceNowToolStripMenuItem;
    }
}

