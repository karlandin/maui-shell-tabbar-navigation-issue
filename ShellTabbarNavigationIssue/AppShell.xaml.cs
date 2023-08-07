namespace ShellTabbarNavigationIssue;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(TestPage2), typeof(TestPage2));
    }
}

