using Microsoft.UI.Xaml.Controls;
using windows_app_coding.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace windows_app_coding;

/// <summary>
/// The main content page displayed inside the application window.
/// </summary>
public sealed partial class HomePage : Page
{
    public HomePageViewModel ViewModel { get; } = new();

    public HomePage()
    {
        InitializeComponent();
    }
}
