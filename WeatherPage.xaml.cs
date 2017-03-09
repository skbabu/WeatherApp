using System;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            this.Title = "Weather App";
            getWeatherBtn.Clicked += GetWeatherBtn_Clicked;

            this.BindingContext = new Weather();
        }

        private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CityEntry.Text))
            {
                Weather weather = await Core.GetWeather(CityEntry.Text);
                if (weather != null)
                {
                    this.BindingContext = weather;
                    getWeatherBtn.Text = "Search Again";
                }
            }
        }

private async void setFavoriteCityBtn_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CityEntry.Text))
            {
                FavoriteCityLabel.Text = CityEntry.Text
            }
        }

    }
}