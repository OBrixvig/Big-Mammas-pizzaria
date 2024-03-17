using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public class PizzaBaker
    {

        //Premade pizzas
        Pizza _nr1 = new Pizza("MAGARITA ", "TOMATO CHEESE ", 69);
        Pizza _nr2 = new Pizza("VESUVIO ", "TOMATO CHEESE & HAM ", 75);
        Pizza _nr3 = new Pizza("CAPRICCIOSA ", "TOMATO CHEESE HAM & MUSHROOMS ", 80);
        Pizza _nr4 = new Pizza("ITALIANO ", "TOMATO CHEESE MEATSOUCE & ONIONS", 80);
        //Pizza Making Method
        public void BakePizzaToList(string name, string topping, int price)
        {
            Pizza CustomPizza = new Pizza(name, topping, price);
            
        }
        //Making properties
        public Pizza nr1 { get { return _nr1; } }
        public Pizza nr2 { get { return _nr2; } }
        public Pizza nr3 { get { return _nr3; } }
        public Pizza nr4 { get { return _nr4; } }
    }
}
