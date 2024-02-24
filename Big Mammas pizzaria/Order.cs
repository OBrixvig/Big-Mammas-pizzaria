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
        CommentMaker _commentMaker = new CommentMaker();

        private int _orderId ;
        private double _totalOrderPrice;
        private DateTime _date;
        private string _orderItems;

        // alt ++
        static int _idCounter;

        public Order()
        {
            ID = _idCounter;
            Date = DateTime.Now;
            _idCounter++;
            _totalOrderPrice = 0;
        }
        //Add pizza methode
        public void  AddPizzaNr1()
        { 
            _totalOrderPrice += menu.nr1.PizzaPrice;
            _orderItems += menu.nr1.Name;
        }

        public void AddPizzaNr2()
        {
            _totalOrderPrice += menu.nr2.PizzaPrice;
            _orderItems += menu.nr2.Name;
        }

        public void AddPizzaNr3()
        {
            _totalOrderPrice += menu.nr3.PizzaPrice;
            _orderItems += menu.nr3.Name;
        }

        //ToString Method
        public override string ToString()
        {
            return  "Your order: " + _orderItems + Environment.NewLine + "Comments: " + _commentMaker.PizzaComment + Environment.NewLine + "Total Price: " + _totalOrderPrice + ",-" + Environment.NewLine + "ordre-id " + ID + Environment.NewLine + "date " + Date.ToString("dd-MM-yyyy :  "+ Environment.NewLine + "kl: HH-mm-fff " + Environment.NewLine );
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
        public double TotalPrice
        { 
            get { return _totalOrderPrice; } 
            set { _totalOrderPrice = value; }
        }
        public string Items
        {
            get { return _orderItems; }
        }

        public Menu menu
        {
            get { return _menu; }
        }
        public CommentMaker Comment
        { 
            get { return _commentMaker; } 
        }
    }
}
