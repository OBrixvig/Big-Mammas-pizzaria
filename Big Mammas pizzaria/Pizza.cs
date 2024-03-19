using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public class Pizza
    {   //pizza
        private string _name;
        private int _pizzaPrice;
        private string _pizzaTopping;
        private string _xtraTopping;
        private int _toppingPrice = 9;

        public Pizza(string name, string topping, int price)
        {
            _name = name;
            _pizzaPrice = price;
            _pizzaTopping = topping;
            _name += _xtraTopping;
        }

        // ToString Method
        public override string ToString()
        {
            string massage = ($"{_name} med {_pizzaTopping}{_xtraTopping} pris {_pizzaPrice} ,-");
            return massage;
        }

        // Making properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int PizzaPrice
        {
            get { return _pizzaPrice; }
            set { _pizzaPrice = value; }
        }
        public string PizzaTopping
        {
            get { return _pizzaTopping; }
            set { _pizzaTopping = value;}
        }
        public string XtraTopping
        {
            get { return _xtraTopping; }
            set { _xtraTopping = value; }
        }
        public int ToppingPrice
        {
            get { return _toppingPrice; }
            set { _toppingPrice = value; }
        }
    }
}