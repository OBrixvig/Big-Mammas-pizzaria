using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public class Order 

    {
        private int _orderId;
        private int _idCounter;
        private double _orderPrice; 
        private string _orderItem;
        private DateTime _date;


        private Menu _nr1;
        private Menu _nr2;
        private Menu _nr3;

        
        public Order() 
        {
            ID = _orderId ;
            Date = DateTime.Now ;
            //_orderItem = orderItems;




            _nr1 = new Menu("MAGARITA", "TOMATO CHEESE", 69);
            _nr2 = new Menu("VESUVIO", "TOMATO CHEESE & HAM", 75);
            _nr3 = new Menu("CAPRICCIOSA", "TOMATO CHEESE HAM & MUSHROOMS", 80);
        }


        public void PizzaChoice( string n1, string nr2, string nr3) 
        {
           string _nr1 = n1;
           string _nr2 = nr2;
           string _nr3 = nr3;
        }


        private int myVar;

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



    }
    



    
}
