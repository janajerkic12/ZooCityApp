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
    public partial class Login : ContentPage
    {
        public User registrovanikorisnik;
        public Login(User _user)
        {
            InitializeComponent();
            registrovanikorisnik = _user;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (registrovanikorisnik.Email == entryEmail.Text && registrovanikorisnik.Sifra == entrySifra.Text)
            {
                await Navigation.PushModalAsync(new Home());
            }
            else
            {
                await DisplayAlert("Pogrešni pristupni podaci", "Porvjerite email i/ili šifru!", "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}