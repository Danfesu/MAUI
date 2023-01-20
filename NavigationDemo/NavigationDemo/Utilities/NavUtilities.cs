using NavigationDemo.MVVM.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationDemo.Utilities
{
    public class NavUtilities
    {
        //Examinar los elementos de la pila
        public static void Examine(INavigation navigation)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var page in navigation.NavigationStack)
            {
                builder.AppendLine(page.GetType().Name);
            }
            builder.AppendLine("------------");
            Debug.WriteLine(builder.ToString());
        }
        // Insertar pagina en la pila
        public static void InsertPage(INavigation navigation)
        {
            var seconPage =
                navigation.NavigationStack
                .ElementAtOrDefault(1);
            if (seconPage!= null)
            {
                navigation.InsertPageBefore(new CoolPage(), seconPage);
            }
        }

        //Eliminar pagina de la pila
        public static void DeletePage(INavigation navigation, string pageName)
        {
            var pageToDelete = navigation.NavigationStack
                .FirstOrDefault(x => x.GetType().Name == pageName);
            if (pageToDelete != null)
            {
                navigation.RemovePage(pageToDelete);
            }
        }
    }
}
