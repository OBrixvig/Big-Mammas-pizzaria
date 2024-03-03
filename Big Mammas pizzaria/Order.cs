using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public class Order
    {
        Menu _menu = new Menu();

        private int _orderId = 0;
        private double _totalOrderPrice;
        private DateTime _date;
        static int _idCounter;
        private double _delevery = 40;

        private string _comment;

        // _discount is used in the constructor and the code for it to work is in get set property. line 72
        private bool _discount = false;

        //Making my _pizzaList where i want to store all my pizzas
        private List<PizzaCreator> _pizzaList = new List<PizzaCreator>();

        public Order(bool club)
        {
            _orderId += ++_idCounter;
            Date = DateTime.Now;
            _totalOrderPrice = 0;
            _discount = club;
            _totalOrderPrice += _delevery;
        }

        //Add pizza method
        public void AddPizzaToList(PizzaCreator pizza)
        {
            _pizzaList.Add(pizza);
            _totalOrderPrice += pizza.PizzaPrice;
        }
        //AddComment Method
        public void AddComment(string WhatYouWantTOSay)
        {
            _comment = WhatYouWantTOSay;
        }

        //ToString Method with a StringBuilder,so my ToString method is a little easier to read..
        public override string ToString()
        {
            StringBuilder sB = new StringBuilder();
            sB.AppendLine("\n" + "Your order: ");

            //Making a foreach so i can spit out the pizzas in my list. just as they are in the ToString in my PizzaCreator Class.
            foreach (PizzaCreator pizza in PizzaList)
            {
                sB.AppendLine(pizza.ToString());
            }
            sB.AppendLine("Comments: " + _comment + "\n" + "\n" + "Delevery: " + _delevery + ",-");
            sB.AppendLine("Total Price: " + TotalPrice + ",- incl. taxes." + "\n" + "ordre-id " + _orderId + "\n");
            sB.AppendLine("date " + Date.ToString("dd-MM-yyyy :  " + "\n" + "kl: HH:mm " + "\n"));
            //returner all the strings i have put in my sB
            return sB.ToString();
        }

        //Making Properties
        public int ID
        {
            get { return _orderId; }
            set { _orderId = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        // in this property i have put _discount boolean in so if true you get totalprice with 20% discount
        public double TotalPrice
        {
            get { return _discount ? ((_totalOrderPrice * .8) * 1.25) : _totalOrderPrice * 1.25; }
        }
        public string PizzaComment
        {
            get { return _comment; }
        }

        public Menu menu
        {
            get { return _menu; }
        }

        public List<PizzaCreator> PizzaList
        {
            get { return _pizzaList; }
        }
    }
}
