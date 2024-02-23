using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public class ToppingList
    {
        List<string> toppings = new List<string>()
        {
        "tomato",
        "ham",
        "mushrooms",
        "shrimp",
        "peppers",
        "mussels",
        "garlic",
        "vegetables",
        "onion",
        "meatSauce",
        "gorgonzola",
        "olives",
        "anchoves",
        "chili",
        "pineapple",
        "tuna",
        "cocktailSausages",
        "bacon",
        "egg",
        "asparagus",
        "parmaHam",
        };
        
        public void Pizza(string top1, string top2)
        {
            Console.WriteLine(toppings.Find(x => x==top1));
        }

    }

}
