﻿namespace PerfectPay;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Creamer.ttf", "MyFont");
                fonts.AddFont("fontello.ttf", "Icons");
                fonts.AddFont("Bison.ttf", "MainFont");
            });

		return builder.Build();
	}
}
