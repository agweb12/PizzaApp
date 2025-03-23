using Newtonsoft.Json;
using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PizzaApp
{
    public partial class MainPage : ContentPage
    {
        //readonly List<Pizza> pizzas;
        public MainPage()
        {
            InitializeComponent();
            const string URL = "https://codeavecjonathan.com/res/pizzas_app_1.json";

            //string pizzaJson = "";
            // pizzaJson = "[\r\n\t{ \"nom\": \"4 fromages\", \"ingredients\": [ \"cantal\", \"mozzarella\", \"fromage de chèvre\", \"gruyère\" ], \"prix\": 11, \"imageUrl\": \"https://www.galbani.fr/wp-content/uploads/2017/07/pizza_filant_montage_2_3.jpg\"},\r\n\t{ \"nom\": \"tartiflette\", \"ingredients\": [ \"pomme de terre\", \"oignons\", \"crème fraiche\", \"lardons\", \"mozzarella\" ], \"prix\": 14, \"imageUrl\": \"https://cdn.pizzamatch.com/1/35/1375105305-pizza-napolitain-630.JPG?1375105310\"},\r\n\t{ \"nom\": \"margherita\", \"ingredients\": [ \"sauce tomate\", \"mozzarella\", \"basilic\" ], \"prix\": 7, \"imageUrl\": \"https://www.misteriosocultos.com/wp-content/uploads/2018/12/pizza.jpg\"},\r\n\t{ \"nom\": \"indienne\", \"ingredients\": [ \"curry\", \"mozzarella\", \"poulet\", \"poivron\", \"oignon\", \"coriandre\" ], \"prix\": 10, \"imageUrl\": \"https://assets.afcdn.com/recipe/20160519/15342_w1024h768c1cx3504cy2338.jpg\"},\r\n\t{ \"nom\": \"mexicaine\", \"ingredients\": [ \"boeuf\", \"mozzarella\", \"maïs\", \"tomates\", \"oignon\", \"coriandre\" ], \"prix\": 13, \"imageUrl\": \"https://fac.img.pmdstatic.net/fit/http.3A.2F.2Fprd2-bone-image.2Es3-website-eu-west-1.2Eamazonaws.2Ecom.2FFAC.2Fvar.2Ffemmeactuelle.2Fstorage.2Fimages.2Fminceur.2Fastuces-minceur.2Fminceur-choix-pizzeria-47943.2F14883894-1-fre-FR.2Fminceur-comment-faire-les-bons-choix-a-la-pizzeria.2Ejpg/750x562/quality/80/crop-from/center/minceur-comment-faire-les-bons-choix-a-la-pizzeria.jpeg\"},\r\n\t{ \"nom\": \"chèvre et miel\", \"ingredients\": [ \"miel\", \"mozzarella\", \"fromage de chèvre\", \"roquette\"], \"prix\": 10, \"imageUrl\": \"http://gfx.viberadio.sn/var/ezflow_site/storage/images/news/conso-societe/les-4-aliments-a-eviter-de-consommer-le-soir-00018042/155338-1-fre-FR/Les-4-aliments-a-eviter-de-consommer-le-soir.jpg\"},\r\n\t{ \"nom\": \"napolitaine\", \"ingredients\": [ \"sauce tomate\", \"mozzarella\", \"anchois\", \"câpres\"], \"prix\": 9, \"imageUrl\": \"https://www.fourchette-et-bikini.fr/sites/default/files/pizza_tomate_mozzarella.jpg\"},\r\n\t{ \"nom\": \"kebab\", \"ingredients\": [ \"poulet\", \"oignons\", \"sauce tomate\", \"sauce kebab\", \"mozzarella\"], \"prix\": 11, \"imageUrl\": \"https://res.cloudinary.com/serdy-m-dia-inc/image/upload/f_auto/fl_lossy/q_auto:eco/x_0,y_0,w_3839,h_2159,c_crop/w_576,h_324,c_scale/v1525204543/foodlavie/prod/recettes/pizza-au-chorizo-et-fromage-cheddar-en-grains-2421eadb\"},\r\n\t{ \"nom\": \"louisiane\", \"ingredients\": [ \"poulet\", \"champignons\", \"poivrons\", \"oignons\", \"sauce tomate\", \"mozzarella\"], \"prix\": 12, \"imageUrl\": \"http://www.fraichementpresse.ca/image/policy:1.3167780:1503508221/Pizza-dejeuner-maison-basilic-et-oeufs.jpg?w=700&$p$w=13b13d9\"},\r\n\t{ \"nom\": \"orientale\", \"ingredients\": [ \"merguez\", \"champignons\", \"sauce tomate\", \"mozzarella\"], \"prix\": 11, \"imageUrl\": \"https://www.atelierdeschefs.com/media/recette-e30299-pizza-pepperoni-tomate-mozza.jpg\"},\r\n\t{ \"nom\": \"hawaïenne\", \"ingredients\": [ \"jambon\", \"ananas\", \"sauce tomate\", \"mozzarella\"], \"prix\": 12, \"imageUrl\": \"https://www.atelierdeschefs.com/media/recette-e16312-pizza-quatre-saisons.jpg\"},\r\n\t{ \"nom\": \"reine\", \"ingredients\": [ \"jambon\", \"champignons\", \"sauce tomate\", \"mozzarella\"], \"prix\": 8, \"imageUrl\": \"https://static.cuisineaz.com/400x320/i96018-pizza-reine.jpg\"},\r\n\r\n]";
            //string urlPizzaJson = "https://drive.google.com/uc?export=download&id=1aQxZoYWBKeSK35W8uTmtHEF9l69sC3vr";
            //Déserialisation du fichier Pizza.JSON


            Console.WriteLine("ETAPE 1");


            using (var webclient = new WebClient())
            {
                try
                {   // Thread MAIN (UI)
                    //pizzaJson = webclient.DownloadString(URL);

                    Console.WriteLine("ETAPE 2");


                    webclient.DownloadStringCompleted += (object sender, DownloadStringCompletedEventArgs e) =>
                    {
                        Console.WriteLine("ETAPE 5");

                        Console.WriteLine("Données Téléchargées : " + e.Result);

                        string pizzaJson = e.Result;

                        List<Pizza> pizzas = JsonConvert.DeserializeObject<List<Pizza>>(pizzaJson);
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            listView.ItemsSource = pizzas;
                        });
                    };
                    Console.WriteLine("ETAPE 3");

                    webclient.DownloadStringAsync(new Uri(URL));

                }
                catch (Exception ex)
                {
                    // Thread Réseau
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        DisplayAlert("Erreur", "Une erreur réseau s'est produite " + ex.Message, "Ok");
                    });
                    return;
                }
            };

            Console.WriteLine("ETAPE 4");


            //pizzas = JsonConvert.DeserializeObject<List<Pizza>>(pizzaJson);

            //pizzas = new List<Pizza>();
            /**
            pizzas = new List<Pizza>
            {
                new Pizza { Nom = "végétarienne", Prix = 7, Ingredients = new string[] { "tomate", "oignon", "poivrons", "courgettes" }, ImageUrl = "https://st3.idealista.it/news/archivie/styles/fullwidth_xl/public/2022-10/media/image/aurelien-lemasson-theobald-x00czbt4dfk-unsplash.jpg?VersionId=V5HNX7jAzvpmOwawvIKLGNATTI3v_m09&itok=KeH-F7_2" },
                new Pizza { Nom = "montagnarde", Prix = 11, Ingredients = new string[] { "reblochon", "raclette", "pomme de terre", "dinde", "oignons", "reblochon", "raclette", "pomme de terre", "dinde", "oignons" }, ImageUrl = "https://pizzahotaufeudebois.fr/wp-content/uploads/2019/09/Montagnarde.jpg" },
                new Pizza { Nom = "carnivore", Prix = 14, Ingredients = new string[] { "tomate", "mozzarella", "viande hachée", "poivrons", "champignons", "olives", "poulet", "veau", "gingembre", "salade", "tomate cerise", "oeufs" } , ImageUrl = "https://www.gangofpizza.com/wp-content/uploads/2024/03/CHILI-2024-GANGOFPIZZA-PIZZA-DU-MOIS-%C2%A9-1080x675.jpg"}
            };*/

            //listView.ItemsSource = pizzas;
        }
    }
}
