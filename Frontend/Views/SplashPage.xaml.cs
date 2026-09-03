using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using windows_app_coding.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace windows_app_coding;

/// <summary>
/// The main content page displayed inside the application window.
/// </summary>
public sealed partial class SplashPage : Page
{
    public SplashPageViewModel ViewModel { get; } = new();

    public SplashPage()
    {
      InitializeComponent();
    }

    private void RegisterBtn(object sender, RoutedEventArgs e)
  {
    Frame.Navigate(typeof(RegisterPage));
  }

  private void LoginBtn(object sender, RoutedEventArgs e)
  {
    
  }
        
}