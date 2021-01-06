
namespace EmotePickerWinForm
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.FilenameListBox = new System.Windows.Forms.ListBox();
            this.EmoteBox = new System.Windows.Forms.PictureBox();
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ClipboardButton = new System.Windows.Forms.Button();
            this.EmoteCheckBox = new System.Windows.Forms.CheckBox();
            this.EmoteSizeLabel = new System.Windows.Forms.Label();
            this.ResultReporterLabel = new System.Windows.Forms.Label();
            this.CopyNameButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmoteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FilenameListBox
            // 
            this.FilenameListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FilenameListBox.FormattingEnabled = true;
            this.FilenameListBox.ItemHeight = 15;
            this.FilenameListBox.Location = new System.Drawing.Point(12, 70);
            this.FilenameListBox.Name = "FilenameListBox";
            this.FilenameListBox.Size = new System.Drawing.Size(184, 184);
            this.FilenameListBox.TabIndex = 0;
            this.FilenameListBox.SelectedIndexChanged += new System.EventHandler(this.FilenameListBox_SelectedIndexChanged);
            // 
            // EmoteBox
            // 
            this.EmoteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmoteBox.BackColor = System.Drawing.SystemColors.Control;
            this.EmoteBox.Location = new System.Drawing.Point(362, 70);
            this.EmoteBox.MinimumSize = new System.Drawing.Size(128, 128);
            this.EmoteBox.Name = "EmoteBox";
            this.EmoteBox.Size = new System.Drawing.Size(128, 128);
            this.EmoteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EmoteBox.TabIndex = 1;
            this.EmoteBox.TabStop = false;
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.AllowDrop = true;
            this.DirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryTextBox.Location = new System.Drawing.Point(12, 12);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.Size = new System.Drawing.Size(393, 23);
            this.DirectoryTextBox.TabIndex = 2;
            this.DirectoryTextBox.TextChanged += new System.EventHandler(this.DirectoryTextBox_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(411, 12);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.AllowDrop = true;
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchTextBox.Location = new System.Drawing.Point(12, 41);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(184, 23);
            this.SearchTextBox.TabIndex = 4;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ClipboardButton
            // 
            this.ClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClipboardButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClipboardButton.Location = new System.Drawing.Point(362, 219);
            this.ClipboardButton.Name = "ClipboardButton";
            this.ClipboardButton.Size = new System.Drawing.Size(128, 35);
            this.ClipboardButton.TabIndex = 5;
            this.ClipboardButton.Text = "Clipboard";
            this.ClipboardButton.UseVisualStyleBackColor = true;
            this.ClipboardButton.Click += new System.EventHandler(this.ClipboardButton_Click);
            // 
            // EmoteCheckBox
            // 
            this.EmoteCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EmoteCheckBox.AutoSize = true;
            this.EmoteCheckBox.Location = new System.Drawing.Point(202, 231);
            this.EmoteCheckBox.Name = "EmoteCheckBox";
            this.EmoteCheckBox.Size = new System.Drawing.Size(148, 19);
            this.EmoteCheckBox.TabIndex = 6;
            this.EmoteCheckBox.Text = "Copy as Discord emote";
            this.EmoteCheckBox.UseVisualStyleBackColor = true;
            // 
            // EmoteSizeLabel
            // 
            this.EmoteSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EmoteSizeLabel.AutoSize = true;
            this.EmoteSizeLabel.Location = new System.Drawing.Point(390, 201);
            this.EmoteSizeLabel.Name = "EmoteSizeLabel";
            this.EmoteSizeLabel.Size = new System.Drawing.Size(57, 15);
            this.EmoteSizeLabel.TabIndex = 7;
            this.EmoteSizeLabel.Text = "Size: 0 x 0";
            // 
            // ResultReporterLabel
            // 
            this.ResultReporterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultReporterLabel.Location = new System.Drawing.Point(202, 41);
            this.ResultReporterLabel.Name = "ResultReporterLabel";
            this.ResultReporterLabel.Size = new System.Drawing.Size(288, 36);
            this.ResultReporterLabel.TabIndex = 8;
            this.ResultReporterLabel.Text = "x results found";
            // 
            // CopyNameButton
            // 
            this.CopyNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyNameButton.Location = new System.Drawing.Point(202, 117);
            this.CopyNameButton.Name = "CopyNameButton";
            this.CopyNameButton.Size = new System.Drawing.Size(85, 23);
            this.CopyNameButton.TabIndex = 9;
            this.CopyNameButton.Text = "Copy Name";
            this.CopyNameButton.UseVisualStyleBackColor = true;
            this.CopyNameButton.Click += new System.EventHandler(this.CopyNameButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RenameButton.Location = new System.Drawing.Point(202, 146);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(85, 23);
            this.RenameButton.TabIndex = 10;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(202, 175);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 23);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 267);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.CopyNameButton);
            this.Controls.Add(this.ResultReporterLabel);
            this.Controls.Add(this.EmoteSizeLabel);
            this.Controls.Add(this.EmoteCheckBox);
            this.Controls.Add(this.ClipboardButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.DirectoryTextBox);
            this.Controls.Add(this.EmoteBox);
            this.Controls.Add(this.FilenameListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(522, 306);
            this.Name = "MainWindow";
            this.Text = "Emote Picker";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmoteBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FilenameListBox;
        private System.Windows.Forms.PictureBox EmoteBox;
        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button ClipboardButton;
        private System.Windows.Forms.CheckBox EmoteCheckBox;
        private System.Windows.Forms.Label EmoteSizeLabel;
        private System.Windows.Forms.Label ResultReporterLabel;
        private System.Windows.Forms.Button CopyNameButton;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

