namespace ControlsDemo;

public partial class InputsControlsDemo : ContentPage
{
	public InputsControlsDemo()
	{
		InitializeComponent();
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		lblSlider.Text = slider.Value.ToString();
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (stepper != null)
        {
            lblSlider.Text = stepper.Value.ToString();
        }
    }
}