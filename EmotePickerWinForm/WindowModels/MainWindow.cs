using EmotePickerWinForm.UIService;
using EmoteResizerLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmotePickerWinForm
{
    public partial class MainWindow : Form
    {
        private List<string> _emoteNames = new List<string>();
        private readonly MainUiService _uiService;
        private readonly EmoteDrawer _emoteDrawer;

        public MainWindow(MainUiService uiService, EmoteDrawer emoteDrawer)
        {
            InitializeComponent();

            // Initialize services
            _uiService = uiService;
            _emoteDrawer = emoteDrawer;
        }

        // When the Browse button is pressed.
        private void BrowseButton_Click(object sender, EventArgs e)
            => _uiService.SelectFolderToTextBox(DirectoryTextBox, FolderBrowserDialog);

        // When the "Copy Name" button is pressed.
        private void CopyNameButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(FilenameListBox.SelectedItem as string);
            _ = ReportTempAction($"Successfully copied \"{FilenameListBox.SelectedItem as string}\".");
        }

        // When the window is opened for the first time.
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Set water mark on text fields
            DirectoryTextBox.SetWatermark("Directory");
            SearchTextBox.SetWatermark("Search");

            // Initialize form controls
            EmoteBox.Image = new Bitmap(1, 1);
            EmoteSizeLabel.Text = string.Empty;
            ResultReporterLabel.Text = string.Empty;
            _uiService.LoadConfig(DirectoryTextBox);
        }

        // When the Rename button is pressed.
        private void RenameButton_Click(object sender, EventArgs e)
        {
            var reWindow = new RenameWindow(EmoteBox.Image, DirectoryTextBox.Text, FilenameListBox.SelectedItem as string);
            reWindow.ShowDialog();
            
            if (reWindow.HasRenamed)
            {
                var oldName = FilenameListBox.SelectedItem as string;
                var newName = reWindow.FileFullName;

                FillFilenameListBox();
                FilenameListBox.SelectedItem = newName;
                _ = ReportTempAction($"Successfully renamed \"{oldName}\" to \"{newName}\".");

                if (FilenameListBox.SelectedItem is null)
                    EnableButtons(false);
            }
        }

        // When the Delete button is pressed.
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var deWindow = new DeleteWindow(EmoteBox.Image, DirectoryTextBox.Text, FilenameListBox.SelectedItem as string);
            deWindow.ShowDialog();

            if (deWindow.HasDeleted)
            {
                var oldName = FilenameListBox.SelectedItem as string;
                
                EmoteBox.Image = new Bitmap(1, 1);
                EmoteSizeLabel.Text = string.Empty;
                FillFilenameListBox();
                _ = ReportTempAction($"Successfully deleted \"{oldName}\".");
                EnableButtons(false);
            }
        }

        // When the user defines the directory folder to search images from.
        private void DirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetWindow();

            if (!Directory.Exists(DirectoryTextBox.Text))
                return;

            FillFilenameListBox();
            _uiService.SaveConfig(DirectoryTextBox.Text);
        }

        // When the user writes a search keyword.
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetWindow();

            if (!Directory.Exists(DirectoryTextBox.Text))
                return;

            FillFilenameListBox();
        }

        // When an item in the list is selected.
        private void FilenameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear and draw new emote
            EmoteBox.Image.Dispose();
            EnableButtons(true);

            var (emote, width, height) = _emoteDrawer.GetEmote(DirectoryTextBox.Text, FilenameListBox.SelectedItem as string, EmoteBox.Width, EmoteBox.Height);
            EmoteBox.Image = emote;
            EmoteSizeLabel.Text = $"Size: {width} x {height}";
        }

        // When the Clipboard button is pressed.
        private void ClipboardButton_Click(object sender, EventArgs e)
        {
            Bitmap image;
            var data = new DataObject();

            if (EmoteCheckBox.Checked)
                image = _emoteDrawer.GetEmote(DirectoryTextBox.Text, FilenameListBox.SelectedItem as string, 48, 48).Item1;
            else
                image = _emoteDrawer.GetImage(DirectoryTextBox.Text, FilenameListBox.SelectedItem as string);

            // This is a hack for Windows' clipboard not being able to preserve transparency on images
            // Save a bmp and a png into the clipboard and pray that the receiving program supports png
            // Hopefully Microsoft will fix that once they update the clipboard on build 20185
            using (var pngStream = new MemoryStream())
            {
                // As standard bitmap, with no transparency support
                data.SetData(DataFormats.Bitmap, true, image);

                // As PNG. Some programs will prefer this over the regular bitmap
                image.Save(pngStream, ImageFormat.Png);
                data.SetData("PNG", false, pngStream);

                // The 'copy=true' argument means the MemoryStreams can be safely disposed after the operation.
                Clipboard.SetDataObject(data, true);
            }

            image.Dispose();
            _ = ReportTempAction($"Successfully copied \"{FilenameListBox.SelectedItem as string}\" to the clipboard.");
        }

        /* Helper Methods */

        /// <summary>
        /// Clears the list and disables the buttons.
        /// </summary>
        public void ResetWindow()
        {
            EmoteBox.Image.Dispose();
            EmoteBox.Image = new Bitmap(1, 1);
            EmoteSizeLabel.Text = string.Empty;
            ResultReporterLabel.Text = string.Empty;
            EnableButtons(false);
            FilenameListBox.Items.Clear();
        }

        /// <summary>
        /// Toggles all buttons on the form.
        /// </summary>
        /// <param name="enable">The toggle.</param>
        /// <remarks>true to enable, false to disable.</remarks>
        public void EnableButtons(bool enable)
        {
            CopyNameButton.Enabled = enable;
            RenameButton.Enabled = enable;
            DeleteButton.Enabled = enable;
            ClipboardButton.Enabled = enable;
        }

        /// <summary>
        /// Sets the ResultReporterLabel to the specified message for 5 seconds.
        /// </summary>
        /// <param name="message">The message to be displayed.</param>
        /// <returns></returns>
        public async Task ReportTempAction(string message)
        {
            var temp = ResultReporterLabel.Text;

            ResultReporterLabel.Text = message;
            await Task.Delay(TimeSpan.FromSeconds(5));
            ResultReporterLabel.Text = temp;
        }

        /// <summary>
        /// Populates the FilenameListBox with emote names.
        /// </summary>
        private void FillFilenameListBox()
        {
            FilenameListBox.Items.Clear();
            _emoteNames.Clear();
            _emoteNames = _emoteDrawer.FetchEmoteNames(DirectoryTextBox.Text).ToList();

            foreach (var emote in _emoteNames)
            {
                if (emote.ToLower().Contains(SearchTextBox.Text.ToLower()))
                    FilenameListBox.Items.Add(emote);
            }

            ResultReporterLabel.Text = $"{FilenameListBox.Items.Count} results were found";
        }
    }
}