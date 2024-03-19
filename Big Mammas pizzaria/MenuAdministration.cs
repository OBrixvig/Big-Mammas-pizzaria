﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace Big_Mammas_pizzaria
{
    public class MenuAdministration
    {
        public MenuAdministration()
        {
        }
        private Pizza _pizza;
        public List<Pizza> MenuList = new List<Pizza>()
        {
        //Pizzas in Menu
             new Pizza("MAGARITA ", "Tomat & ost ", 69),
             new Pizza("VESUVIO ", "Tomat ost & skinke ", 75),
             new Pizza("CAPRICCIOSA ", "Tomat ost skinke & champignon ", 80),
             new Pizza("ITALIANO ", "Tomat ost kødsovs & løg", 80)
        };
        //Create new pizza to MenuList
        public void CreatePizzaToMenuList(string name, string topping, int price)
        {
            // _pizza = new Pizza(name, topping, price);
            //MenuList.Add(_pizza);
            Pizza pizza = new Pizza(name, topping, price);
            MenuList.Add(pizza);
        }
        //Add Pizza To MenuList
        public void AddPizzaToMenuList(Pizza pizza)
        {
            MenuList.Add(pizza);
        }

        //Remove Pizza method
        public void RemovePizzaFromMenuList(Pizza pizza)
        {
            MenuList.Remove(pizza);
        }

        //Update PizzaTopping method
        public void UpdatePizzaToppingFromList(Pizza pizza, string pizzaTopping)
        {
            pizza.PizzaTopping = pizzaTopping;
        }
        //Recive All Pizza from the menu, but i got a ToString that does the same so meh for this one.
        public void ReciveAllItemsMenuList()
        {
            foreach (Pizza pizzas in MenuList)
            {
                Console.WriteLine(pizzas);
            }
        }
        //Recive one specefik item in MenuList
        public void RecivePizzaFromMenuList(Pizza pizza)
        {
            MenuList.Contains(pizza);
            Console.WriteLine(pizza);
        }

        //ToString Method with a StringBuilder
        public override string ToString()
        {
            StringBuilder sB = new StringBuilder();
            sB.AppendLine("Big mammas MENU" + "\n");

            //Making a foreach so i can get the pizzas in my Menulist. just as they are in the ToString in my PizzaCreator Class.
            foreach (Pizza Menu in MenuList)
            {
                sB.AppendLine(Menu.ToString());
            }
            sB.AppendLine("\n" + "Levering er 40 kr." + "\n");
            //Returning all the strings i have put in my sB
            return sB.ToString();
        }
    }
}