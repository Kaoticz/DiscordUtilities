using EmoteResizerLibrary;
using EmoteResizerWinForm.Models;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace EmoteResizerWinForm.UIService
{
    public class MainUiService
    {
        private readonly EmoteResizer _emoteResizer;

        public MainUiService(EmoteResizer emoteResizer)
        {
            _emoteResizer = emoteResizer;
        }

        public void SaveConfig(ConfigModel config, string configPath)
        {
            var toJson = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(configPath, toJson);
        }

        public ConfigModel LoadConfig(string configPath)
        {
            var fromJson = File.ReadAllText(configPath);
            return JsonSerializer.Deserialize<ConfigModel>(fromJson, new JsonSerializerOptions { WriteIndented = true });
        }

        public DialogResult SelectFolderToTextBox(TextBox textBox, FolderBrowserDialog fbDialog)
        {
            var result = fbDialog.ShowDialog();

            if (result == DialogResult.OK)
                textBox.Text = fbDialog.SelectedPath;

            return result;
        }

        public string[] ReportSearchResult(TextBox textBox, Label emoteReporterLabel)
        {
            var emoteNames = _emoteResizer.FetchEmoteNames(textBox.Text);
            emoteReporterLabel.Text = $"{((emoteNames.Length == 0) ? "No" : emoteNames.Length)} valid images were found.";

            return emoteNames;
        }
    }
}