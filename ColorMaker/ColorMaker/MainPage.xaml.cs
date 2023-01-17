
using CommunityToolkit.Maui.Alerts;
using System.Diagnostics;

namespace ColorMaker;

public partial class MainPage : ContentPage
{
    bool isRandom;
    string hexValue;
    public MainPage()
    {
        InitializeComponent();
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (!isRandom)
        {
            var red = sldRed.Value;
            var green = sldGreen.Value;
            var blue = sldBlue.Value;

            Color color = Color.FromRgb(red, green, blue);

            SetColor(color);
        }
    }

    private void SetColor(Color color)
    {
        btnRandom.BackgroundColor = color;
        Container.BackgroundColor = color;
        hexValue = color.ToHex();
        lblHex.Text = color.ToHex();
    }

    private void btnRandom_Clicked(object sender, EventArgs e)
    {
        isRandom = true;

        var random = new System.Random();

        var color = Color.FromRgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));

        SetColor(color);
        SetSliderValue(color.Red, color.Green, color.Blue);

        isRandom = false;
    }

    private void SetSliderValue(float red, float green, float blue)
    {
        sldRed.Value = red;
        sldGreen.Value = green;
        sldBlue.Value = blue;
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Clipboard.SetTextAsync(hexValue);
        var toast = Toast.Make("Color copied", CommunityToolkit.Maui.Core.ToastDuration.Short, 12);
        await toast.Show();
    }
}

