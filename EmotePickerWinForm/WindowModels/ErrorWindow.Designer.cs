
namespace EmotePickerWinForm
{
    partial class ErrorWindow
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
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.OkErrorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.Location = new System.Drawing.Point(12, 18);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(220, 82);
            this.ErrorMessageLabel.TabIndex = 0;
            this.ErrorMessageLabel.Text = "Error Message";
            this.ErrorMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OkErrorButton
            // 
            this.OkErrorButton.Location = new System.Drawing.Point(88, 103);
            this.OkErrorButton.Name = "OkErrorButton";
            this.OkErrorButton.Size = new System.Drawing.Size(75, 23);
            this.OkErrorButton.TabIndex = 1;
            this.OkErrorButton.Text = "Ok";
            this.OkErrorButton.UseVisualStyleBackColor = true;
            this.OkErrorButton.Click += new System.EventHandler(this.OkErrorButton_Click);
            // 
            // ErrorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 138);
            this.Controls.Add(this.OkErrorButton);
            this.Controls.Add(this.ErrorMessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ErrorWindow";
            this.Load += new System.EventHandler(this.ErrorWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Button OkErrorButton;
    }
}