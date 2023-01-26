using CollectionViewDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewDemo.Selectors
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product =
                item as Product;
            return !product.HasOffer ? 
                GetDataTemplate("ProductStyle") 
                : GetDataTemplate("OfferStyle");
        }

        private DataTemplate GetDataTemplate(string nameStyle)
        {
            Application.
                    Current.
                    Resources.
                    TryGetValue(nameStyle, out var aux);
            return aux as DataTemplate;
        }
    }
}
