
namespace EmotePickerWinForm
{
    partial class RenameWindow
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
            this.RenameLabel = new System.Windows.Forms.Label();
            this.RenameTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RenameLabel
            // 
            this.RenameLabel.AutoSize = true;
            this.RenameLabel.Location = new System.Drawing.Point(12, 20);
            this.RenameLabel.Name = "RenameLabel";
            this.RenameLabel.Size = new System.Drawing.Size(124, 15);
            this.RenameLabel.TabIndex = 0;
            this.RenameLabel.Text = "Rename {filename} to:";
            // 
            // RenameTextBox
            // 
            this.RenameTextBox.AllowDrop = true;
            this.RenameTextBox.Location = new System.Drawing.Point(12, 48);
            this.RenameTextBox.Name = "RenameTextBox";
            this.RenameTextBox.Size = new System.Drawing.Size(354, 23);
            this.RenameTextBox.TabIndex = 1;
            this.RenameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RenameTextBox_KeyUp);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(225, 90);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(85, 90);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // RenameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 121);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RenameTextBox);
            this.Controls.Add(this.RenameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 160);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(395, 160);
            this.Name = "RenameWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "RenameWindow";
            this.Load += new System.EventHandler(this.RenameWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RenameLabel;
        private System.Windows.Forms.TextBox RenameTextBox;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
    }
}