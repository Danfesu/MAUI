using CollectionViewDemo.MVVM.ViewModels;
using System.Diagnostics;

namespace CollectionViewDemo.MVVM.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();

		BindingContext = new ProductsViewModel();
	}

    private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
		Debug.WriteLine(e.HorizontalDelta);
        Debug.WriteLine(e.VerticalDelta);
        Debug.WriteLine(e.HorizontalOffset);
        Debug.WriteLine(e.VerticalOffset);
        Debug.WriteLine(e.FirstVisibleItemIndex);
        Debug.WriteLine(e.CenterItemIndex);
        Debug.WriteLine(e.LastVisibleItemIndex);

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var vm =
            BindingContext as ProductsViewModel;

        vm.Products.Add(new Models.ProductsGroup("New Group", new List<Models.Product>
        {
            new Models.Product
            {
                Id=100,
                Name="Bitcoin",
                Price=9999
            }
        }));

        var product =
            vm.Products
            .SelectMany(p=>p)
            .FirstOrDefault(x=>x.Id == 10);

        //collectionView.ScrollTo(10);
        //collectionView.ScrollTo(product, position: ScrollToPosition.Start);
    }
}