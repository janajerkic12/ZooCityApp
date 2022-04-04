using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZooCityApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void kupiKartuButton(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new KupiKartu());
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ListingZivotinje());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            var location = new Location(44.5346033, 18.7069295);
            var options = new MapLaunchOptions { Name = "Negdje u BiH" };

            try
            {
                await Map.OpenAsync(location, options);
            }
            catch (Exception ex)
            {
                // No map application available to open
            }

        }
    }
}