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
    public partial class ListingZivotinje : ContentPage
    {
        public IList<ZivotinjeVrste> vrste { get; set; }
        public ListingZivotinje()
        {
            InitializeComponent();

            vrste = new List<ZivotinjeVrste>();

            vrste.Add(new ZivotinjeVrste { naziv = "Morske", image = "tambaqui.png"});
            vrste.Add(new ZivotinjeVrste { naziv = "Kopnene", image = "animal_land_water.png"});
            vrste.Add(new ZivotinjeVrste { naziv = "Domaće", image = "animal_earth.png"});
            vrste.Add(new ZivotinjeVrste { naziv = "Divlje", image = "polar_bear.png"});
            vrste.Add(new ZivotinjeVrste { naziv = "Ptice", image = "animal_air.png"});
            BindingContext = this;
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myListView = (ListView)sender;
            var odabranaKategorija = (ZivotinjeVrste)myListView.SelectedItem;
            await Navigation.PushModalAsync(new AnimalDetail(odabranaKategorija));
        }
    }
}