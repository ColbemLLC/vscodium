using System.Windows.Controls;

namespace Codium.Resources;

public partial class WelcomePage : UserControl
{
    public WelcomePage()
    {
        InitializeComponent();
    }

    private void MicrosoftLogin_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        // TODO: call AuthService.SignInWithMicrosoftAsync()
    }

    private void GoogleLogin_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        // TODO: call AuthService.SignInWithGoogleAsync()
    }

    private void ColbeLogin_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        // TODO: call AuthService.SignInWithColbeAsync()
    }
}