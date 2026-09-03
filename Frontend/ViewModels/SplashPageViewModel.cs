using CommunityToolkit.Mvvm.ComponentModel;

namespace windows_app_coding.ViewModels;

/// <summary>
/// Sample ViewModel using CommunityToolkit.Mvvm partial property syntax.
/// Uses <see cref="ObservableProperty"/> for change notification and
/// <see cref="RelayCommand"/> for command binding.
/// </summary>

public partial class SplashPageViewModel : ObservableObject
{
    [ObservableProperty]
    public partial string WelcomeMessage { get; set; }  = "Welcome to Cododo!";

    [ObservableProperty]
    public partial string RegisterPrompt { get; set; } ="Are you new here?";

    [ObservableProperty]
    public partial string LoginPrompt  { get; set; } = "Already have an account?";

    [ObservableProperty]
    public partial string Description { get; set; } = "Cododo is a platform build for developers, students and everyone who likes to code!\nCreate a new account today and start your coding journey with us. We can't wait for you to join us!";

    
}