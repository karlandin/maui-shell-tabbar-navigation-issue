namespace ShellTabbarNavigationIssue;

public class TestPage2 : ContentPage
{
    public TestPage2()
    {
        Content = new VerticalStackLayout
        {
            Children =
            {
                new Label
                {
                    Text = "TestPage2"
                }
            }
        };
    }
}