
namespace EmoteResizerWinForm
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
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.EmoteReporterLabel = new System.Windows.Forms.Label();
            this.OutputLink = new System.Windows.Forms.LinkLabel();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SourceBrowseButton = new System.Windows.Forms.Button();
            this.OutputBrowseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceTextBox.Location = new System.Drawing.Point(12, 36);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(409, 23);
            this.SourceTextBox.TabIndex = 0;
            this.SourceTextBox.TextChanged += new System.EventHandler(this.SourceTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Directory";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(12, 91);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(409, 23);
            this.OutputTextBox.TabIndex = 2;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // ResizeButton
            // 
            this.ResizeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResizeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResizeButton.Location = new System.Drawing.Point(161, 190);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(149, 45);
            this.ResizeButton.TabIndex = 4;
            this.ResizeButton.Text = "Resize";
            this.ResizeButton.UseVisualStyleBackColor = true;
            this.ResizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
            // 
            // EmoteReporterLabel
            // 
            this.EmoteReporterLabel.AutoSize = true;
            this.EmoteReporterLabel.Location = new System.Drawing.Point(12, 142);
            this.EmoteReporterLabel.Name = "EmoteReporterLabel";
            this.EmoteReporterLabel.Size = new System.Drawing.Size(116, 15);
            this.EmoteReporterLabel.TabIndex = 5;
            this.EmoteReporterLabel.Text = "Reports search result";
            // 
            // OutputLink
            // 
            this.OutputLink.AutoSize = true;
            this.OutputLink.Location = new System.Drawing.Point(12, 117);
            this.OutputLink.Name = "OutputLink";
            this.OutputLink.Size = new System.Drawing.Size(193, 15);
            this.OutputLink.TabIndex = 6;
            this.OutputLink.TabStop = true;
            this.OutputLink.Text = "Gives clickable link to output folder";
            this.OutputLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OutputLink_LinkClicked);
            // 
            // SourceBrowseButton
            // 
            this.SourceBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceBrowseButton.Location = new System.Drawing.Point(427, 35);
            this.SourceBrowseButton.Name = "SourceBrowseButton";
            this.SourceBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.SourceBrowseButton.TabIndex = 7;
            this.SourceBrowseButton.Text = "Browse";
            this.SourceBrowseButton.UseVisualStyleBackColor = true;
            this.SourceBrowseButton.Click += new System.EventHandler(this.SourceBrowseButton_Click);
            // 
            // OutputBrowseButton
            // 
            this.OutputBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBrowseButton.Location = new System.Drawing.Point(427, 91);
            this.OutputBrowseButton.Name = "OutputBrowseButton";
            this.OutputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.OutputBrowseButton.TabIndex = 8;
            this.OutputBrowseButton.Text = "Browse";
            this.OutputBrowseButton.UseVisualStyleBackColor = true;
            this.OutputBrowseButton.Click += new System.EventHandler(this.OutputBrowseButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 251);
            this.Controls.Add(this.OutputBrowseButton);
            this.Controls.Add(this.SourceBrowseButton);
            this.Controls.Add(this.OutputLink);
            this.Controls.Add(this.EmoteReporterLabel);
            this.Controls.Add(this.ResizeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 290);
            this.Name = "MainWindow";
            this.Text = "Discord Emote Resizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.Label EmoteReporterLabel;
        private System.Windows.Forms.LinkLabel OutputLink;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button SourceBrowseButton;
        private System.Windows.Forms.Button OutputBrowseButton;
    }
}

