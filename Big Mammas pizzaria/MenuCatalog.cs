using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Big_Mammas_pizzaria
{
    public class MenuCatalog
    {
        public MenuCatalog()
        {
                
        }
        public List<Pizza> MenuList = new List<Pizza>()
        {
        //Pizzas in Menu
        new Pizza("MAGARITA ", "TOMATO CHEESE ", 69),
        new Pizza("VESUVIO ", "TOMATO CHEESE & HAM ", 75),
        new Pizza("CAPRICCIOSA ", "TOMATO CHEESE HAM & MUSHROOMS ", 80),
        new Pizza("ITALIANO ", "TOMATO CHEESE MEATSOUCE & ONIONS", 80)
        };
        
        public override string ToString()
        {
            StringBuilder sB = new StringBuilder();
            sB.AppendLine("Big mammas MENU ");

            //Making a foreach so i can get the pizzas in my Menulist. just as they are in the ToString in my PizzaCreator Class.
            foreach (Pizza Menu in MenuList)
            {
                sB.AppendLine(Menu.ToString());
            }
            sB.AppendLine("Delevery is 40,-" + "\n" + "You can make your own pizza just ask.");
            //returner all the strings i have put in my sB
            return sB.ToString();

        }

    }
}