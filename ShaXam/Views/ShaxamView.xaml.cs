using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ShaXam.Views
{
    public partial class ShaxamView : ContentView
    {
        public ShaxamView()
        {
            InitializeComponent();

            TapGestureRecognizer libraryTapGestureRecognizer = new TapGestureRecognizer();
            libraryTapGestureRecognizer.Tapped+= (sender, e) =>
            {
                MessagingCenter.Send("0", "ChangeCarouselPosition");
            };
            LibrarySL.GestureRecognizers.Add(libraryTapGestureRecognizer);

            TapGestureRecognizer chartsTapGestureRecognizer = new TapGestureRecognizer();
            chartsTapGestureRecognizer.Tapped += (sender, e) =>
            {
                MessagingCenter.Send("2", "ChangeCarouselPosition");
            };
            ChartsSL.GestureRecognizers.Add(chartsTapGestureRecognizer);

        }
    }
}
