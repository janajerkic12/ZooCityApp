using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZooCityApp.Models;
/*
{ nazivZivotinje = "Ptica Trkačica", imeUZoo = "Lili", slika = "https://upload.wikimedia.org/wikipedia/commons/b/b8/Strauss_m_Tanzania.jpg", poticeOd = "Mauricijus", lajkovi = "0.52", opis = "Slatka mala ptica veoma druželjubiva. Voli djecu i da se igra sa svojim prijateljima."}*/

namespace ZooCityApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalDetail : ContentPage
    {
        public IList<Zivotinje> zivotinje { get; set; }
        public AnimalDetail(ZivotinjeVrste odabrana)
        {
            InitializeComponent();

            zivotinje = new List<Zivotinje>();

            if(odabrana.naziv == "Morske")
            {
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Delfin", imeUZoo = "Nina", slika = "https://www.os-novska.hr/media/k2/items/cache/211520f6c4dff2679a31b5ccb6899176_XL.jpg", poticeOd = "Chile", lajkovi = "0.40", opis = "Poznat je po svojoj inteligenciji i navodnom saosećanju i radosti." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Riba Klaun", imeUZoo = "Leo", slika = "https://zoo.hr/wp-content/uploads/2019/12/285B0549.jpg", poticeOd = "Jugoistočna Azija", lajkovi = "0.50", opis = "Mlada riba mora proći kroz period aklimatizacije dok ne postane imuna na otrov vlasulje." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Foka", imeUZoo = "Teo", slika = "https://pbs.twimg.com/media/EpRKWO9W8AcV4VX?format=jpg&name=small", poticeOd = "Sjeverno more", lajkovi = "0.38", opis = "Imaju male ušne školjke koje su vidljive izvan krzna, a uz pomoć peraja mogu da podignu tijelo sa zemlje." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Pjegava slatkovodna raža", imeUZoo = "Maricela", slika = "https://zoo.hr/wp-content/uploads/2019/12/285B4936-scaled.jpg", poticeOd = "Južna Amerika", lajkovi = "0.48", opis = "Vrsta migrira unutar slatkih voda, a migracije su rijetko kraće od 100 km." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Zmijolika mnogoperka", imeUZoo = "Ana", slika = "https://zoo.hr/wp-content/uploads/2019/12/285B4936-scaled.jpg", poticeOd = "Tropska Afrika", lajkovi = "0.21", opis = "Foslili vrste datiraju u doba jure, prije 200 milijuna godina." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Crveni tajlandski rak", imeUZoo = "Kan", slika = "https://slika.nezavisne.rs/2018/01/750x450/20180120213558_461204.jpg", poticeOd = "Jugiostočna Azija", lajkovi = "0.32", opis = "Društvene su životinje stoga ih se treba uvijek držati u većem broju." });
            }
            else if (odabrana.naziv == "Kopnene")
            {
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Zebra", imeUZoo = "Leis", slika = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Equus_quagga.jpg/1280px-Equus_quagga.jpg", poticeOd = "Jugoistočna Afrika", lajkovi = "0.59", opis = "Raspored i izgled pruga je jedinstven za svaku jedinku zebre – poput otisaka prsta kod čovjeka." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Čimpanza", imeUZoo = "Liam", slika = "https://www.tportal.hr/media/thumbnail/w1000/428261.jpeg", poticeOd = "Zapadna Afrika", lajkovi = "0.61", opis = "Kao alat koriste kamenje, komade drveta, grančice i naoštrene grane poput koplja." });
            }
            else if (odabrana.naziv == "Domaće")
            {
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Zec", imeUZoo = "Filip", slika = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Oryctolagus_cuniculus_Tasmania_2b.jpg/800px-Oryctolagus_cuniculus_Tasmania_2b.jpg", poticeOd = "Europa", lajkovi = "0.25", opis = "Zec smatra da je svaki napad uperen protiv njega." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Magarac", imeUZoo = "Hugo", slika = "http://zoopalic.com/wp-content/uploads/2018/03/magarac-1.jpg", poticeOd = "Europa", lajkovi = "0.35", opis = "Njihov izvorni oblik je afrički divlji magarac." });
            }
            else if (odabrana.naziv == "Divlje")
            {
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Medvjed", imeUZoo = "Etta", slika = "https://upload.wikimedia.org/wikipedia/commons/3/33/Ours_brun_parcanimalierpyrenees_3.jpg", poticeOd = "Europa", lajkovi = "0.60", opis = "U hodu medvjedi dodiruju tlo cijelim tabanima – slično kao čovjek." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Afrički lav", imeUZoo = "Uzuri", slika = "https://zoo.hr/wp-content/uploads/2019/03/afri%C4%8Dka-lavica.jpg", poticeOd = "Afrika", lajkovi = "0.22", opis = "Rika lava može se čuti i do 5 kilometara udaljenosti." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Sivi vuk", imeUZoo = "Iris", slika = "https://zoo.hr/wp-content/uploads/2019/01/canis_lupus_2008_oggy_126.jpg", poticeOd = "Bliski Istok", lajkovi = "0.11", opis = "U Hrvatskoj mu je boja krzna uvijek siva; leđa i rep su tamnosive boje koja prema trbuhu i nogama prelazi u svijetlosivu" });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Kineski leopard", imeUZoo = "Jan", slika = "https://zoo.hr/wp-content/uploads/2019/07/Leopard.jpg", poticeOd = "Sjeverna Kina", lajkovi = "0.95", opis = "Nakon što su ubili lovinu, plijen vuku i do 100 m kako bi ga sakrili u gustu vegetaciju ili odvukli na stablo." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Crvena vjeverica", imeUZoo = "Kani", slika = "https://static.jutarnji.hr/images/slike/2021/08/04/o_12071275_1280.jpg", poticeOd = "Sjeverna Azija", lajkovi = "0.65", opis = "Glavni uzorci ugroženosti su gubitak staništa i fragmentacija istog kao i invazivne vrste." });
            }
            else
            {
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Ptica Trkačica", imeUZoo = "Lili", slika = "https://upload.wikimedia.org/wikipedia/commons/b/b8/Strauss_m_Tanzania.jpg", poticeOd = "Mauricijus", lajkovi = "0.52", opis = "Slatka mala ptica veoma druželjubiva. Voli djecu i da se igra sa svojim prijateljima." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Crveni ibis", imeUZoo = "Mak", slika = "https://i0.hippopx.com/photos/140/370/575/ibis-red-bird-valence-preview.jpg", poticeOd = "Brazil", lajkovi = "0.11", opis = "Crvena boja perja blijedi kod ptica u zoološkim vrtovima ako im prehrana ne uključuje visoku razinu proteina i meso škampa." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Mala bijela čaplja", imeUZoo = "Leon", slika = "https://www.naturephoto-cz.com/photos/birds/mala-bijela-caplja-12175.jpg", poticeOd = "Azija", lajkovi = "0.70", opis = "U prošlosti su, kao i mnoge druge čaplje, bile lovljene zbog perja, kojim su ljudi ukrašavali šešire." });
                zivotinje.Add(new Zivotinje { nazivZivotinje = "Pupavac", imeUZoo = "Noa", slika = "https://tris.com.hr/wp-content/uploads/2020/12/pup1.jpg", poticeOd = "Azija", lajkovi = "0.90", opis = "Latinsko ime roda Upupa zapravo predstavlja onomatopeju, stilsku figuru u kojoj se riječima oponašaju zvukovi iz prirode, odnosno u ovom slučaju glasanje pupavca." });
            }

            BindingContext = this;
        }
     
    }
}