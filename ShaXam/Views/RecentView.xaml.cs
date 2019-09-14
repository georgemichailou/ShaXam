using System;
using System.Collections.Generic;
using ShaXam.Models;
using Xamarin.Forms;

namespace ShaXam.Views
{
    public partial class RecentView : ContentView
    {
        public RecentView()
        {
            InitializeComponent();

            RecentList.ItemsSource = new List<Album>
            {
                new Album(){ singerName= "Ed Sheeran", songImg="https://upload.wikimedia.org/wikipedia/en/thumb/8/80/Ed_Sheeran_Perfect_Single_cover.jpg/220px-Ed_Sheeran_Perfect_Single_cover.jpg", songTitle="Perfect"},
                new Album(){ singerName= "Cecilia Krull", songImg="https://m.media-amazon.com/images/I/81JJCZm-2AL._SS500_.jpg", songTitle="My Life Is Going On"},
                new Album(){ singerName= "Little Big Town", songImg="https://m.media-amazon.com/images/I/819T9NEmdXL._SS500_.jpg", songTitle="Summer Fever"},
                new Album(){ singerName= "Imagine Dragons", songImg="https://i1.sndcdn.com/artworks-000417287439-z0hnqd-t500x500.jpg", songTitle="Believer"},
                new Album(){ singerName= "VENENO", songImg="https://i.scdn.co/image/e0a97d1c01328b6d610237f4a02c88ae8c10b0f1", songTitle="Izquierda Derecha"},
            };
        }
    }
}
