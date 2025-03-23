using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PizzaApp.Model;
using Xamarin.Forms;

namespace PizzaApp
{
    public partial class MainPage : ContentPage
    {
        //List<Pizza> pizzas;

        public MainPage()
        {
            InitializeComponent();



            //string pizzasJson = "[{\"nom\":\"4 fromages\",\"ingredients\":[\"cantal\",\"mozzarella\",\"fromage de chèvre\",\"gruyère\"],\"prix\":11,\"imageUrl\":\"https://www.galbani.fr/wp-content/uploads/2017/07/pizza_filant_montage_2_3.jpg\"},{\"nom\":\"tartiflette\",\"ingredients\":[\"pomme de terre\",\"oignons\",\"crème fraiche\",\"lardons\",\"mozzarella\"],\"prix\":14,\"imageUrl\":\"https://cdn.pizzamatch.com/1/35/1375105305-pizza-napolitain-630.JPG?1375105310\"},{\"nom\":\"margherita\",\"ingredients\":[\"sauce tomate\",\"mozzarella\",\"basilic\"],\"prix\":7,\"imageUrl\":\"https://www.misteriosocultos.com/wp-content/uploads/2018/12/pizza.jpg\"},{\"nom\":\"indienne\",\"ingredients\":[\"curry\",\"mozzarella\",\"poulet\",\"poivron\",\"oignon\",\"coriandre\"],\"prix\":10,\"imageUrl\":\"https://assets.afcdn.com/recipe/20160519/15342_w1024h768c1cx3504cy2338.jpg\"},{\"nom\":\"mexicaine\",\"ingredients\":[\"boeuf\",\"mozzarella\",\"maïs\",\"tomates\",\"oignon\",\"coriandre\"],\"prix\":13,\"imageUrl\":\"https://fac.img.pmdstatic.net/fit/http.3A.2F.2Fprd2-bone-image.2Es3-website-eu-west-1.2Eamazonaws.2Ecom.2FFAC.2Fvar.2Ffemmeactuelle.2Fstorage.2Fimages.2Fminceur.2Fastuces-minceur.2Fminceur-choix-pizzeria-47943.2F14883894-1-fre-FR.2Fminceur-comment-faire-les-bons-choix-a-la-pizzeria.2Ejpg/750x562/quality/80/crop-from/center/minceur-comment-faire-les-bons-choix-a-la-pizzeria.jpeg\"},{\"nom\":\"chèvre et miel\",\"ingredients\":[\"miel\",\"mozzarella\",\"fromage de chèvre\",\"roquette\"],\"prix\":10,\"imageUrl\":\"http://gfx.viberadio.sn/var/ezflow_site/storage/images/news/conso-societe/les-4-aliments-a-eviter-de-consommer-le-soir-00018042/155338-1-fre-FR/Les-4-aliments-a-eviter-de-consommer-le-soir.jpg\"},{\"nom\":\"napolitaine\",\"ingredients\":[\"sauce tomate\",\"mozzarella\",\"anchois\",\"câpres\"],\"prix\":9,\"imageUrl\":\"https://www.fourchette-et-bikini.fr/sites/default/files/pizza_tomate_mozzarella.jpg\"},{\"nom\":\"kebab\",\"ingredients\":[\"poulet\",\"oignons\",\"sauce tomate\",\"sauce kebab\",\"mozzarella\"],\"prix\":11,\"imageUrl\":\"https://res.cloudinary.com/serdy-m-dia-inc/image/upload/f_auto/fl_lossy/q_auto:eco/x_0,y_0,w_3839,h_2159,c_crop/w_576,h_324,c_scale/v1525204543/foodlavie/prod/recettes/pizza-au-chorizo-et-fromage-cheddar-en-grains-2421eadb\"},{\"nom\":\"louisiane\",\"ingredients\":[\"poulet\",\"champignons\",\"poivrons\",\"oignons\",\"sauce tomate\",\"mozzarella\"],\"prix\":12,\"imageUrl\":\"http://www.fraichementpresse.ca/image/policy:1.3167780:1503508221/Pizza-dejeuner-maison-basilic-et-oeufs.jpg?w=700&$p$w=13b13d9\"},{\"nom\":\"orientale\",\"ingredients\":[\"merguez\",\"champignons\",\"sauce tomate\",\"mozzarella\"],\"prix\":11,\"imageUrl\":\"https://www.atelierdeschefs.com/media/recette-e30299-pizza-pepperoni-tomate-mozza.jpg\"},{\"nom\":\"hawaïenne\",\"ingredients\":[\"jambon\",\"ananas\",\"sauce tomate\",\"mozzarella\"],\"prix\":12,\"imageUrl\":\"https://www.atelierdeschefs.com/media/recette-e16312-pizza-quatre-saisons.jpg\"},{\"nom\":\"reine\",\"ingredients\":[\"jambon\",\"champignons\",\"sauce tomate\",\"mozzarella\"],\"prix\":8,\"imageUrl\":\"https://static.cuisineaz.com/400x320/i96018-pizza-reine.jpg\"}]";

            //string pizzasJson = "";

            listView.RefreshCommand = new Command((obj) =>
            {
                Console.WriteLine("RefreshCommand");
                DownloadData((pizzas) =>
                {
                    listView.ItemsSource = pizzas;
                    listView.IsRefreshing = false;
                });
            });

            listView.IsVisible = false;
            waitLayout.IsVisible = true;

            Console.WriteLine("ETAPE 1");


            // Appel a ma fonction
            DownloadData((pizzas) =>
            {
                listView.ItemsSource = pizzas;

                listView.IsVisible = true;
                waitLayout.IsVisible = false;
            });


            // Thread


            Console.WriteLine("ETAPE 4");


            //pizzas = JsonConvert.DeserializeObject<List<Pizza>>(pizzasJson);

            //pizzas = new List<Pizza>();

            //imageUrl
            /*
            pizzas.Add(new Pizza { nom = "végétarienne", prix = 7, ingredients = new string[] { "tomate", "poivrons", "oignons" }, imageUrl= "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/Eq_it-na_pizza-margherita_sep2005_sml.jpg/280px-Eq_it-na_pizza-margherita_sep2005_sml.jpg" });
            pizzas.Add(new Pizza { nom = "MONTAGNARDE", prix = 11, ingredients = new string[] { "reblochon", "pomme de terre", "oignons", "crème fraiche", "lardons", "olives", "tomates", "oeufs", "camembert" }, imageUrl= "https://assets.afcdn.com/recipe/20170105/24149_w1024h768c1cx2592cy1728.jpg" });
            pizzas.Add(new Pizza { nom = "Carnivore", prix = 14, ingredients = new string[] { "tomate", "viande hachée", "mozzarella" }, imageUrl = "https://recipes.timesofindia.com/photo/53110049.cms" });
            */

            // completez le code

            //listView.ItemsSource = pizzas;
        }


        public void DownloadData(Action<List<Pizza>> action)
        {
            //const string URL = "https://codeavecjonathan.com/res/pizzas_app_1.json";
            const string URL = "https://pizzamamajr.azurewebsites.net/api/getpizzas";

            using (var webclient = new WebClient())
            {

                    // Thread Main (UI)
                    //pizzasJson = webclient.DownloadString(URL);

                    Console.WriteLine("ETAPE 2");

                    webclient.DownloadStringCompleted += (object sender, DownloadStringCompletedEventArgs e) => {
                        //
                        Console.WriteLine("ETAPE 5");

                        //Console.WriteLine("Données téléchargées: " + e.Result);
                        try
                        {
                            string pizzasJson = e.Result;

                            List<Pizza> pizzas = JsonConvert.DeserializeObject<List<Pizza>>(pizzasJson);

                            //

                            Device.BeginInvokeOnMainThread(() =>
                            {
                                action.Invoke(pizzas);

                            });

                        }
                        catch (Exception ex)
                        {
                            // Thread réseau
                            Device.BeginInvokeOnMainThread(() =>
                            {
                                DisplayAlert("Erreur", "Une erreur réseau s'est produite: " + ex.Message, "OK");
                                action.Invoke(null);
                            });
                        }

                    };

                    Console.WriteLine("ETAPE 3");

                    webclient.DownloadStringAsync(new Uri(URL));
                

            }
        }
    }
}
