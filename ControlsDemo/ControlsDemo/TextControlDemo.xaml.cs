using Android.OS;

namespace ControlsDemo;

public partial class TextControlDemo : ContentPage
{
	public TextControlDemo()
	{
		InitializeComponent();
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        System.Diagnostics.Debug.WriteLine(txtName.Text);
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine(txtName.Text);
    }
}