using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public class Menu
    {
        //Pizzas in Menu
        PizzaCreator _nr1 = new PizzaCreator("MAGARITA ", "TOMATO CHEESE ", 69);
        PizzaCreator _nr2 = new PizzaCreator("VESUVIO ", "TOMATO CHEESE & HAM ", 75);
        PizzaCreator _nr3 = new PizzaCreator("CAPRICCIOSA ", "TOMATO CHEESE HAM & MUSHROOMS ", 80);
        public override string ToString()
        {
            return "Big mammas MENU " + Environment.NewLine + _nr1 + Environment.NewLine + _nr2 + Environment.NewLine + _nr3 + Environment.NewLine;
        }
        //Making properties
        public PizzaCreator nr1 { get { return _nr1; } }
        public PizzaCreator nr2 { get { return _nr2; } }
        public PizzaCreator nr3 { get { return _nr3; } }
    }
}