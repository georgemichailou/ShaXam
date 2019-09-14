using System;
using ShaXam.Views;
using Xamarin.Forms;

namespace ShaXam.UIHelper
{
    public class CustomViewSelector : DataTemplateSelector
    {
        private DataTemplate view1 = new DataTemplate(typeof(RecentView));
        private DataTemplate view2 = new DataTemplate(typeof(ShaxamView));
        private DataTemplate view3 = new DataTemplate(typeof(DiscoverView));

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            // I don't use 'new' at every time as I do need to retain views status
            Type currentView = item as Type;

            if (currentView == typeof(RecentView))
                return view1;
            else if (currentView == typeof(ShaxamView))
                return view2;
            return view3;
        }
    }
}
