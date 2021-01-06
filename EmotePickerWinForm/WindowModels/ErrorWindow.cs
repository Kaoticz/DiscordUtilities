using System;
using System.Windows.Forms;

namespace EmotePickerWinForm
{
    public partial class ErrorWindow : Form
    {
        private readonly string _errorMessage;

        public ErrorWindow(string er)
        {
            InitializeComponent();
            _errorMessage = er;
        }

        private void ErrorWindow_Load(object sender, EventArgs e)
            => ErrorMessageLabel.Text = _errorMessage;

        private void OkErrorButton_Click(object sender, EventArgs e)
            => Close();
    }
}
