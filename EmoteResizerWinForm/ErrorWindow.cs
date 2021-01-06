using System;
using System.Windows.Forms;

namespace EmoteResizerWinForm
{
    public partial class ErrorWindow : Form
    {
        private readonly string _errorMessage;

        public ErrorWindow(string er)
        {
            _errorMessage = er;
            InitializeComponent();
        }

        private void ErrorWindow_Load(object sender, EventArgs e) => ErrorMessageLabel.Text = _errorMessage;

        private void OkErrorButton_Click(object sender, EventArgs e) => this.Close();
    }
}