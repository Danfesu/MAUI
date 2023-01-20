namespace NavigationDemo.MVVM.Pages;

public partial class CoolPage : ContentPage
{
	public CoolPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopModalAsync();
    }

    protected override bool OnBackButtonPressed()
    {
        return true;
    }
}