

namespace PerfectPay.SesionesMaui.Session9_CodeQuotes;

public partial class CodeQuotes : ContentPage
{
    List<string> quotes = new List<string>();
    public CodeQuotes()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadMauiAsset();
    }

    private void btnGenerateQuote_Clicked(object sender, EventArgs e)
    {
        var random = new Random();

        var startColor = System.Drawing.Color.FromArgb(
        	random.Next(0, 256),
                  random.Next(0, 256),
                  random.Next(0, 256)
                  );
        var endColor = System.Drawing.Color.FromArgb(
            random.Next(0, 256),
            random.Next(0, 256),
            random.Next(0, 256)
            );

        var colors =
            ColorUtility.ColorControls.GetColorGradient(
                startColor,
                endColor,
                6);

        float stopOffset = .0f;
        var stops = new GradientStopCollection();
        foreach (var c in colors)
        {
            stops.Add(new GradientStop(Color.FromArgb(c.Name), stopOffset));
            stopOffset += 0.2f;
        }

        var gradient =
            new LinearGradientBrush(stops, new Point(0, 0), new Point(1, 1));
        background.Background = gradient;

        int index = random.Next(quotes.Count);

        quote.Text = quotes[index];

        //background.Background = new LinearGradientBrush()
        //{
        //    StartPoint = new Point(0, 0),
        //    EndPoint = new Point(0, 1),
        //    GradientStops = new GradientStopCollection()
        //    {
        //        new GradientStop(){ Color = Microsoft.Maui.Graphics.Color.FromRgb(0.2,0.3,0.4), Offset=0 },
        //        new GradientStop(){ Color = Microsoft.Maui.Graphics.Color.FromRgb(1,1,1), Offset = 1}

        //    }
        //};
    }

    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("quotes.txt");
        using var reader = new StreamReader(stream);

        while (reader.Peek() != -1)
        {
            quotes.Add(reader.ReadLine());
        }
    }
}