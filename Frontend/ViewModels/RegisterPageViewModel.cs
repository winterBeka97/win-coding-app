using CommunityToolkit.Mvvm.ComponentModel;

namespace windows_app_coding.ViewModels;

/// <summary>
/// Sample ViewModel using CommunityToolkit.Mvvm partial property syntax.
/// Uses <see cref="ObservableProperty"/> for change notification and
/// <see cref="RelayCommand"/> for command binding.
/// </summary>

public partial class RegisterPageViewModel : ObservableObject
{
    [ObservableProperty]
    public partial string Name { get; set; }  = "Name";

    [ObservableProperty]
    public partial string Username { get; set; }  = "Username";

    [ObservableProperty]
    public partial string Email { get; set; } = "Your email";

    [ObservableProperty]
    public partial string Password { get; set; } = "Create a password";

    [ObservableProperty]
    
    public partial string ConfirmPassword { get; set; } = "Confirm password"; 
    
}