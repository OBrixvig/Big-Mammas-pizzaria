﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public class Menu
    {   //pizaen
        private string _name;
        private int _pizzaPrice;
        private string _pizzaTopping;

        //toppings
        private string _xtraTopping;
      

        // Topping price
            private int _toppingPrice = 9;

        private int _totalPicePrice = ;

        // Pizza Creator

        public Menu(string name,string topping, int price)
        {
            _name = name;
            _pizzaPrice = price;
            _pizzaTopping = topping;
        }

        // add topping
        public void AddTopping(string top)
        {
             _xtraTopping = top;
             
            _pizzaPrice += _toppingPrice;
        }


        // ToString Method
        public override string ToString()
        {
            string massage = ($"{_name} with {_pizzaTopping}{_xtraTopping} Price {_pizzaPrice} ,-");
                
                return massage;
        }

        public void PizzaTotaltPrice()
        {
            _totalPicePrice = _pizzaPrice + _pizzaPrice;
    }

        // Making properties
        public string Name
        {
            get { return _name; }

        }
        public int PizzaPrice
        {
            get { return _pizzaPrice; }

        }
        public string PizzaTopping
        {
            get { return _pizzaTopping; }

        }
        public string XtraTopping
        {
            get { return _xtraTopping; }

        }
        public int ToppingPrice
        {
            get { return _toppingPrice; }

        }
    }
    


}
