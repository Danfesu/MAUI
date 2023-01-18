using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class SumDemo : ContentPage
{
	public SumDemo()
	{
		InitializeComponent();
		BindingContext = new SumDemoViewModel();
	}
}