using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WeatherApp
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new WeatherPage());
        }

        protected override void OnStart()
        {
         if (!String.IsNullOrEmpty (FavoriteCityLabel.Text))
            {
		    Weather weather = await Core.GetWeather						(FavoriteCityLabel.Text);
            }

        protected override void OnSleep()
        {
            
        }

        protected override void OnResume()
        {
            
        }
    }
}
