using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageFlyout : ContentPage
    {
        public ListView ListView;

        public MainPageFlyout()
        {
            InitializeComponent();

            BindingContext = new MainPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class MainPageFlyoutViewModel
        {
            public ObservableCollection<MainPageFlyoutMenuItem> MenuItems { get; set; }

            public MainPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MainPageFlyoutMenuItem>(new[]
                {
                    new MainPageFlyoutMenuItem { Id = 0, Title = "About Weather", TargetType=typeof(AboutPage) },
                    new MainPageFlyoutMenuItem { Id = 1, Title = "Debug Console", TargetType=typeof(ConsolePage) },
                    new MainPageFlyoutMenuItem { Id = 2, Title = "Irsta", TargetType=typeof(ForecastPage) },
                     new MainPageFlyoutMenuItem { Id = 3, Title = "Västerås", TargetType=typeof(ForecastPage) },
                       new MainPageFlyoutMenuItem { Id = 4, Title = "Mikkeli", TargetType=typeof(ForecastPage) },
                         new MainPageFlyoutMenuItem { Id = 5, Title = "Malmö", TargetType=typeof(ForecastPage) },
                           new MainPageFlyoutMenuItem { Id = 6, Title = "Växjö", TargetType=typeof(ForecastPage) },
                             new MainPageFlyoutMenuItem { Id = 7, Title = "Linköping", TargetType=typeof(ForecastPage) },

                });
            }
        }
    }
}