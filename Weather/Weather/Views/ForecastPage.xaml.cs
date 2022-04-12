using System;
using System.Linq;
using System.Threading.Tasks;
using Weather.Models;
using Weather.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ForecastPage : ContentPage
    {
        
        OpenWeatherService service;
        GroupedForecast groupedforecast;

        public ForecastPage()
        {
            InitializeComponent();

            service = new OpenWeatherService();
            groupedforecast = new GroupedForecast();
        }

        protected override void OnAppearing()
        {

            base.OnAppearing();

            weatherLabel.Text = $"Weather in {Title}";

           

            
          
            
            //Code here will run right before the screen appears
            //You want to set the Title or set the City

            //This is making the first load of data
            MainThread.BeginInvokeOnMainThread(async () => { await LoadForecast(); });

           
            
        }

        private async Task LoadForecast()
        {
            

            Forecast fc = await service.GetForecastAsync(Title);
            groupedforecast.Items = fc.Items.GroupBy (f => f.DateTime.Date);
            weatherListView.ItemsSource = groupedforecast.Items;


        }

  
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await LoadForecast();
        }
    }
}