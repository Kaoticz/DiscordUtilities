using EmotePickerWinForm.UIService;
using EmoteResizerLibrary;
using System;
using System.Windows.Forms;

namespace EmotePickerWinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Initialize services
            var uiService = new MainUiService();
            var emoteDrawer = new EmoteDrawer();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(uiService, emoteDrawer));
        }
    }
}