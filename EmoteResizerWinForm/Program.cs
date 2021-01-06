using EmoteResizerLibrary;
using EmoteResizerWinForm.UIService;
using System;
using System.Windows.Forms;

namespace EmoteResizerWinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Initialize service objects
            var emoteResizer = new EmoteResizer();
            var uiService = new MainUiService(emoteResizer);
            
            // Initialize application
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(uiService, emoteResizer));
        }
    }
}