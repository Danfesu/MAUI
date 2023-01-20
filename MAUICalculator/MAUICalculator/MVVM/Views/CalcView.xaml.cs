using MAUICalculator.MVVM.ViewModels;

namespace MAUICalculator.MVVM.Views;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();

		BindingContext = new CalcViewModel();
	}
}