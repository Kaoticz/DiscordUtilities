using EmoteResizerLibrary;
using EmoteResizerWinForm.Models;
using EmoteResizerWinForm.UIService;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace EmoteResizerWinForm
{
    public partial class MainWindow : Form
    {
        // Variables
        private readonly string _configPath = AppDomain.CurrentDomain.BaseDirectory + @"\config.json";
        private string[] _emoteNames;

        // Services
        private readonly ConfigModel _config;
        private readonly MainUiService _uiService;
        private readonly EmoteResizer _emoteResizer;

        public MainWindow(MainUiService uiService, EmoteResizer emoteResizer)
        {
            InitializeComponent();
            _uiService = uiService;
            _emoteResizer = emoteResizer;

            // If config file doesn't exist, create it
            if (!File.Exists(_configPath))
            {
                _config = new ConfigModel();
                _uiService.SaveConfig(_config, _configPath);
            }
            else
            {
                _config = _uiService.LoadConfig(_configPath);
            }

            SourceTextBox.Text = _config.SourceDirectory;
            OutputTextBox.Text = _config.OutputDirectory;
            OutputLink.Text = _config.OutputDirectory;
            EmoteReporterLabel.Text = string.Empty;
        }

        private void SourceBrowseButton_Click(object sender, EventArgs e)
        {
            var result = _uiService.SelectFolderToTextBox(SourceTextBox, FolderBrowserDialog);

            if (result == DialogResult.OK)
                _emoteNames = _uiService.ReportSearchResult(SourceTextBox, EmoteReporterLabel);
        }

        private void SourceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SourceTextBox.Text == string.Empty)
                EmoteReporterLabel.Text = string.Empty;
            else if (Directory.Exists(SourceTextBox.Text))
                _emoteNames = _uiService.ReportSearchResult(SourceTextBox, EmoteReporterLabel);
            else
                EmoteReporterLabel.Text = "Invalid path.";
        }

        private void OutputBrowseButton_Click(object sender, EventArgs e)
        {
            var result = _uiService.SelectFolderToTextBox(OutputTextBox, FolderBrowserDialog);

            if (result == DialogResult.OK)
                OutputLink.Text = OutputTextBox.Text;
        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(OutputTextBox.Text))
                OutputLink.Text = OutputTextBox.Text;
            else
                OutputLink.Text = string.Empty;
        }

        private void OutputLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", OutputTextBox.Text);
            }
            catch (Exception ex)
            {
                new ErrorWindow($"Failed to start Windows Explorer [{ex.Message}]").Show();
            }
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {
            if (_emoteNames is null || _emoteNames.Length == 0 || OutputLink.Text == string.Empty)
                return;

            // Ensure the images in the folder are up-to-date
            _emoteNames = _emoteResizer.FetchEmoteNames(SourceTextBox.Text);

            // Update config object in preparation for the serialization
            _config.SourceDirectory = SourceTextBox.Text;
            _config.OutputDirectory = OutputTextBox.Text;

            try
            {
                _ = _emoteResizer.ProcessEmotes(_emoteNames, SourceTextBox.Text, OutputTextBox.Text);    // Save emotes to output folder
                _uiService.SaveConfig(_config, _configPath);                                         // Save config file
                EmoteReporterLabel.Text = $"{_emoteNames.Length} images were successfully resized.";
            }
            catch (Exception ex)
            {
                new ErrorWindow($"Please, make sure the Source and Output folders exist and are not read-only. [{ex.Message}]").Show();
            }
        }
    }
}