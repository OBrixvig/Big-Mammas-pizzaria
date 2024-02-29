using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public class PizzaCreator
    {   //pizza
        private string _name;
        private int _pizzaPrice;
        private string _pizzaTopping;

        //Addtopping
        private string _xtraTopping;

        //Topping price
        private int _toppingPrice = 9;

        //Pizza Creator
        public PizzaCreator(string name, string topping, int price)
        {
            _name = name;
            _pizzaPrice = price;
            _pizzaTopping = topping;
            _name += _xtraTopping;
        }

        // add topping virker ikke
        public void AddTopping(string top)
        {
            _xtraTopping = top;
            _pizzaPrice += _toppingPrice;
        }

        // ToString Method
        public override string ToString()
        {
            string massage = ($"{_name}with {_pizzaTopping}{_xtraTopping} Price {_pizzaPrice} ,-");
            return massage;
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