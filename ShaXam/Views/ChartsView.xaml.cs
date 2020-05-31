using System;
using System.Collections.Generic;
using ShaXam.Models;
using Xamarin.Forms;

namespace ShaXam.Views
{
    public partial class ChartsView : ContentView
    {
        public ChartsView()
        {
            InitializeComponent();

            ChartsList.ItemsSource = new List<Chart>
            {
                new Chart(){ 
                    chartName="Greece Chart", 
                    chartAlbums=new List<Album>()
                    {
                        new Album(){ singerName= "Ed Sheeran", songImg="https://upload.wikimedia.org/wikipedia/en/thumb/8/80/Ed_Sheeran_Perfect_Single_cover.jpg/220px-Ed_Sheeran_Perfect_Single_cover.jpg", songTitle="Perfect"},
                        new Album(){ singerName= "Cecilia Krull", songImg="https://m.media-amazon.com/images/I/81JJCZm-2AL._SS500_.jpg", songTitle="My Life Is Going On"},
                        new Album(){ singerName= "Little Big Town", songImg="https://m.media-amazon.com/images/I/819T9NEmdXL._SS500_.jpg", songTitle="Summer Fever"}
                    }
                },
                new Chart(){
                    chartName="Global Chart",
                    chartAlbums=new List<Album>()
                    {
                        new Album(){ singerName= "Ed Sheeran", songImg="https://upload.wikimedia.org/wikipedia/en/thumb/8/80/Ed_Sheeran_Perfect_Single_cover.jpg/220px-Ed_Sheeran_Perfect_Single_cover.jpg", songTitle="Perfect"},
                        new Album(){ singerName= "Cecilia Krull", songImg="https://m.media-amazon.com/images/I/81JJCZm-2AL._SS500_.jpg", songTitle="My Life Is Going On"},
                        new Album(){ singerName= "Little Big Town", songImg="https://m.media-amazon.com/images/I/819T9NEmdXL._SS500_.jpg", songTitle="Summer Fever"}
                    }
                },
                new Chart(){
                    chartName="New York City Chart",
                    chartAlbums=new List<Album>()
                    {
                        new Album(){ singerName= "Ed Sheeran", songImg="https://upload.wikimedia.org/wikipedia/en/thumb/8/80/Ed_Sheeran_Perfect_Single_cover.jpg/220px-Ed_Sheeran_Perfect_Single_cover.jpg", songTitle="Perfect"},
                        new Album(){ singerName= "Cecilia Krull", songImg="https://m.media-amazon.com/images/I/81JJCZm-2AL._SS500_.jpg", songTitle="My Life Is Going On"},
                        new Album(){ singerName= "Little Big Town", songImg="https://m.media-amazon.com/images/I/819T9NEmdXL._SS500_.jpg", songTitle="Summer Fever"}
                    }
                },
                new Chart(){
                    chartName="Rome Chart",
                    chartAlbums=new List<Album>()
                    {
                        new Album(){ singerName= "Ed Sheeran", songImg="https://upload.wikimedia.org/wikipedia/en/thumb/8/80/Ed_Sheeran_Perfect_Single_cover.jpg/220px-Ed_Sheeran_Perfect_Single_cover.jpg", songTitle="Perfect"},
                        new Album(){ singerName= "Cecilia Krull", songImg="https://m.media-amazon.com/images/I/81JJCZm-2AL._SS500_.jpg", songTitle="My Life Is Going On"},
                        new Album(){ singerName= "Little Big Town", songImg="https://m.media-amazon.com/images/I/819T9NEmdXL._SS500_.jpg", songTitle="Summer Fever"}
                    }
                }
            };
        }
    }
}
