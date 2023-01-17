using PerfectPay.SesionesMaui.Session10_DatabindingDemo.Models;

namespace PerfectPay.SesionesMaui.Session10_DatabindingDemo;

public partial class DatabindingDemo : ContentPage
{
    Person person = new Person();
	public DatabindingDemo()
	{
		InitializeComponent();

        person = new Person()
        {
            Name = "Test",
            Phone = "3138570531",
            Address = "X Address"
        };

        BindingContext = person;
    }

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
        person.Name = "Peter";
        person.Phone = "000";
        person.Address = "New Address";

		//var person = new Person()
		//{
		//	Name= "Test",
		//	Phone="3138570531",
		//	Address="X Address"
		//};

		//BindingContext= person;

		//txtName.BindingContext= person;
  //      txtName.SetBinding(Label.TextProperty, "Name");

        //Binding personBinding = ne
        //w Binding();

        //personBinding.Source = person;
        //personBinding.Path = "Name";

        //txtName.SetBinding(Label.TextProperty, personBinding);
    }
}