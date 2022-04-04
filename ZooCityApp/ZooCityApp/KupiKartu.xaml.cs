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
    public partial class KupiKartu : ContentPage
    {
        public KupiKartu()
        {
            InitializeComponent();
            Posjeta.MinimumDate = DateTime.Now;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            string ime = imeEntry.Text;
            string prezime = prezimeEntry.Text;
            string email = emailEntry.Text;
            string odraslih = odrasli.Value.ToString();
            string djece = djeca.Value.ToString();
            string datum = Posjeta.Date.ToString("dd.MM.yyyy");

            string Message =
                    "Rezervacija je na ime: " + ime + " " + prezime + $"\nRezervacija je napravljena za datum: " + datum + $" \nBroj karti za odrasle: " + odraslih + $"\nBroj karti za djecu: " + djece + "\n\nUkupna cijena je: " + (int.Parse(odraslih)*7+int.Parse(djece)*3) + " KM";

            await DisplayAlert("Vaša rezervacija je uspjela", Message, "OK");
            
        }
    }
}