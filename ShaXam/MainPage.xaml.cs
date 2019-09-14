using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private int _position;
        public int Position { get { return _position; } set { _position = value; OnPropertyChanged(); } }

        public MainPage()
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            AvaiableViews = new List<Type>() { typeof(RecentView), typeof(ShaxamView), typeof(DiscoverView) };

            BindingContext = this;

        }
    }
}
