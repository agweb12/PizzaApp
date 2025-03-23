using PizzaApp.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Models
{
    public class Pizza
    {
        public string Nom { get; set; }
        public int Prix { get; set; }
        public string[] Ingredients { get; set; }

        public string ImageUrl {  get; set; }
        public string PrixEuros
        {
            get
            {
                return Prix + "€";
            }
        }

        public string IngredientsStr
        {
            get
            {
                return string.Join(", ", Ingredients);
            }
        }

        public string Titre
        {
            get
            {
                return Nom.Capitalize();
            }
        }
        public Pizza()
        {

        }
    }
}
