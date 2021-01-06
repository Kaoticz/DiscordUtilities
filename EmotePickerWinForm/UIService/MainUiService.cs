using System.IO;
using System.Windows.Forms;

namespace EmotePickerWinForm.UIService
{
    public class MainUiService
    {
        public void SaveConfig(string textboxText)
        {
            if (!File.Exists("config.dat"))
                File.Create("config.dat").Close();

            File.WriteAllText("config.dat", textboxText);
        }

        public void LoadConfig(TextBox textBox)
        {
            if (File.Exists("config.dat"))
                textBox.Text = File.ReadAllText("config.dat");
        }

        public DialogResult SelectFolderToTextBox(TextBox textBox, FolderBrowserDialog fbDialog)
        {
            var result = fbDialog.ShowDialog();

            if (result == DialogResult.OK)
                textBox.Text = fbDialog.SelectedPath;

            return result;
        }
    }
}