using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EmotePickerWinForm
{
    public partial class DeleteWindow : Form
    {
        private readonly string _filePath;
        private readonly string _fileName;
        private readonly Image _emote;
        public bool HasDeleted { get; private set; } = false;

        public DeleteWindow(Image emote, string filePath, string fileName)
        {
            InitializeComponent();

            // Initialize variables
            _emote = emote;
            _filePath = filePath + '\\';
            _fileName = fileName;
        }

        private void DeleteWindow_Load(object sender, EventArgs e)
            => DeleteLabel.Text = $"Are you sure you want to delete \"{_fileName}\"?";

        private void CancelButton_Click(object sender, EventArgs e)
            => Close();

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                _emote.Dispose();
                File.Delete(_filePath + _fileName);
                HasDeleted = true;
            }
            catch (Exception ex)
            {
                new ErrorWindow($"An error has occurred.\n[{ex.Message}]").ShowDialog();
            }
            finally
            {
                Close();
            }
        }
    }
}
