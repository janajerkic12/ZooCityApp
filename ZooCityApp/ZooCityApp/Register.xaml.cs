using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZooCityApp.Models;

namespace ZooCityApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (entrySifra.Text == entryPotvrdiSifru.Text)
            {
              

                User user = new User
                {
                    ImePrezime = entryImePrezime.Text,
                    Sifra = entrySifra.Text,
                    Email = entryEmail.Text
                };

                await Navigation.PushModalAsync(new Login(user));
            }

            else
            {
                await DisplayAlert("Greška", "Šifra i Potvrda šife morajau biti identični!", "OK");
            }

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}