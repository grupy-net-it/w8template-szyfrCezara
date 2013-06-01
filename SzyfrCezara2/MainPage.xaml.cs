using StyleMVVM.DependencyInjection;

using Windows.UI.Xaml.Controls;

namespace SzyfrCezara2
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    [Export]
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            DataContext = new ViewModel();
        }

        private void PlainText_TextChanged(object sender, Windows.UI.Xaml.Controls.TextChangedEventArgs e)
        {
            (DataContext as ViewModel).Encrypt((sender as TextBox).Text);
        }

        private void CipherText_TextChanged(object sender, Windows.UI.Xaml.Controls.TextChangedEventArgs e)
        {
            (DataContext as ViewModel).Decrypt((sender as TextBox).Text);
        }
    }
}
