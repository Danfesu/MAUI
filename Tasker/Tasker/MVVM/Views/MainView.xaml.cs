using System.Threading.Tasks;
using Tasker.MVVM.ViewModels;

namespace Tasker.MVVM.Views;

public partial class MainView : ContentPage
{
	private MainViewModel viewModel = new MainViewModel();
	public MainView()
	{
		InitializeComponent();

		BindingContext = viewModel;
	}

    private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		viewModel.UpdateData();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var vm = BindingContext as MainViewModel;
        var taskView = new NewTaskView
        {
            BindingContext = new NewTaskViewModel
            {
                Tasks = vm.Tasks,
                Categories = vm.Categories
            }
        };
        Navigation.PushAsync(taskView);
    }
}