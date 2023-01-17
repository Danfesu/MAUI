using PerfectPay.SesionesMaui.PerfectPay;
using PerfectPay.SesionesMaui.Session_8_ExternalResourcesDemo;
using PerfectPay.SesionesMaui.Session9_CodeQuotes;
using PerfectPay.SesionesMaui.Session10_DatabindingDemo;
using PerfectPay.SesionesMaui.Session10_DatabindingDemo.Pages;

namespace PerfectPay;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new DatabindingDemo();
	}
}
