namespace ShellTabbarNavigationIssue;

public class TestPage1 : ContentPage
{
    public TestPage1()
    {
        var btn1 = new Button
        {
            Text = "GoToPageAsync",
        };
        btn1.Clicked += Btn1_Clicked;

        var btn2 = new Button
        {
            Text = "Navigation.PushAsync",
        };
        btn2.Clicked += Btn2_Clicked;

        var label = new Label
        {
            Text = "TestPage1"
        };

        Content = new VerticalStackLayout
        {
            Children =
            {
                label,
                btn1,
                btn2,
            }
        };
    }

    private void Btn1_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(TestPage2));
    }

    private void Btn2_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new TestPage2());
    }
}