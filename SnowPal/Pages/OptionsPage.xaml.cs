using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SnowPal.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OptionsPage : Page
    {
        public OptionsPage()
        {
            this.InitializeComponent();
            ThemeToggle.IsOn = App.CurrentTheme == ElementTheme.Dark;
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        { App.SetTheme(ThemeToggle.IsOn ? ElementTheme.Dark : ElementTheme.Light); }


        private void BackButton_Click(object sender, RoutedEventArgs e)
        { Frame.Navigate(typeof(MenuPage)); }
    }
}
