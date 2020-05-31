using System;
using System.Collections.Generic;
using System.ComponentModel;
using ShaXam.DependencyServices;
using ShaXam.Views;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ShaXam
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {

        public List<Type> AvaiableViews { get; set; } // Must have default value or be set before the BindingContext is set.

        public MainPage()
        {
            InitializeComponent();
            
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            AvaiableViews = new List<Type>() { typeof(RecentView), typeof(ShaxamView), typeof(ChartsView) };

            BindingContext = this;

            MessagingCenter.Subscribe<string>(this, "ChangeCarouselPosition", (sender) =>
            {
                MainCarousel.Position = Convert.ToInt16(sender);
            });
             
            MainCarousel.PositionChanged += (sender, e) =>
            {
                switch (e.CurrentPosition)
                {
                    case 1:
                        DependencyService.Get<IStatusBarStyleManager>().SetColoredStatusBar("#2196F3");
                        MainBG.BackgroundColor = (Color)Xamarin.Forms.Application.Current.Resources["DarkBlue"];
                        break;
                    case 0:
                    case 2:
                        DependencyService.Get<IStatusBarStyleManager>().SetWhiteStatusBar();
                        MainBG.BackgroundColor = Color.White;
                        break;
                    default:
                        break;
                }
            };

            MainCarousel.Position = 1;
        }
    }
}
