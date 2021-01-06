using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EmotePickerWinForm
{
    public partial class RenameWindow : Form
    {
        private readonly string _filePath;
        private readonly string _fileNameExt;
        private readonly Image _emote;
        public bool HasRenamed { get; private set; } = false;
        public string FileName { get; private set; }
        public string FileFullName { get => FileName + _fileNameExt; }
        
        public RenameWindow(Image emotePreview, string filePath, string fileName)
        {
            InitializeComponent();

            // Initialize variables
            _filePath = filePath + '\\';
            FileName = fileName.Remove(fileName.LastIndexOf('.'));
            _fileNameExt = fileName[fileName.LastIndexOf('.')..];
            _emote = emotePreview;
        }

        private void CancelButton_Click(object sender, EventArgs e)
            => Close();

        private void RenameWindow_Load(object sender, EventArgs e)
        {
            // Initialize controls
            RenameTextBox.Text = FileName;
            RenameLabel.Text = $"Rename \"{FileName}\" to:";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Free the file handle
                _emote.Dispose();

                // Rename the file
                File.Move(
                    _filePath + FileName + _fileNameExt,
                    _filePath + RenameTextBox.Text + _fileNameExt
                );

                FileName = RenameTextBox.Text;
                HasRenamed = true;
                Close();
            }
            catch (Exception ex)
            {
                new ErrorWindow($"An error has occurred.\n[{ex.Message}]").ShowDialog();
            }
        }

        private void RenameTextBox_KeyUp(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Enter)
                OkButton_Click(sender, key);
            else if (key.KeyCode == Keys.Escape)
                CancelButton_Click(sender, key);
        }
    }
}
