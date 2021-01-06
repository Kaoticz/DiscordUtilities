using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace EmotePickerAvalonia
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void BrowseButton_Click(AvaloniaObject sender, AvaloniaPropertyChangedEventArgs e)
        {

        }
    }
}
