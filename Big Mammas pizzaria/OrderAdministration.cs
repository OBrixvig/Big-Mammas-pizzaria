using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public class OrderAdministration 
    {
        MenuAdministration catalog;

        private int _orderId = 0;
        private double _totalOrderPrice;
        private DateTime _date;
        static int _idCounter;
        private double _delivery = 40;
        private bool _ifChekedOut = false;
        private string _comment;

        // _discount is used in the constructor and the code for it to work is in get set property. line 72
        private bool _discount = false;

        //Making my _pizzaList where i want to store all my pizzas
        private List<Pizza> _pizzaList = new List<Pizza>();

        public OrderAdministration(bool customerClub)
        {
            _orderId += ++_idCounter;
            Date = DateTime.Now;
            _totalOrderPrice = 0;
            _totalOrderPrice += _delivery;
            _discount = customerClub;
        }


        //Add pizza method
        public void AddPizzaToList(Pizza pizza)
        {
            _pizzaList.Add(pizza);
        }
        //AddComment Method
        public void AddComment(string WhatYouWantTOSay)
        {
            _comment = WhatYouWantTOSay;
        }
        //Remove Pizza method
        public void RemovePizzaFromList(Pizza pizza)
        {
            _pizzaList.Remove(pizza);
        }
        public void UpdatePizzaToppingFromList(Pizza pizza)
        {

        }

        //ToString Method with a StringBuilder,so my ToString method is a little easier to read..
        public override string ToString()
        {
            StringBuilder sB = new StringBuilder();
            sB.AppendLine("\n" + "Your order: ");

            //Making a foreach so i can spit out the pizzas in my list. just as they are in the ToString in my PizzaCreator Class.
            foreach (Pizza pizza in PizzaList)
            {
                sB.AppendLine(pizza.ToString());
            }
            sB.AppendLine("Comments: " + _comment + "\n" + "\n" + "Delivery: " + _delivery + "kr.");
            sB.AppendLine("Total Price: " + String.Format("{0:0.00}", TotalPrice) + "kr. incl. taxes." + "\n" + "ordre-id " + _orderId + "\n");
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
        // and a boolean so that my order prices dont get ++ every time i call this property
        public double TotalPrice
        {
            get
            {
                if (!_ifChekedOut)
                {
                    _ifChekedOut = !_ifChekedOut;
                    foreach (Pizza p in PizzaList)
                    {
                        _totalOrderPrice += p.PizzaPrice;
                    }
                }
                return _discount ? ((_totalOrderPrice * .8)*1.25) : _totalOrderPrice *1.25;
            }
        }
        public string PizzaComment
        {
            get { return _comment; }
        }


        public bool Discount
        {
            get { return _discount; }
        }

        public List<Pizza> PizzaList
        {
            get { return _pizzaList; }
        }
    }
}
