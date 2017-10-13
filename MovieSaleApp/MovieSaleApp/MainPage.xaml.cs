using MovieSaleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MovieSaleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnNewButtonClicked(object sender, EventArgs args)
        {
            Movie movie = new Movie() { Title = movieName.Text, ListPrice = 5.50, InventoryDate = DateTime.Now };
            await App.Database.SaveItemAsync(movie);
        }

        public async void OnGetButtonClicked(object sender, EventArgs args)
        {
            var movies = await App.Database.GetItemsAsync();
            movieList.ItemsSource = movies;
        }
    }
}
