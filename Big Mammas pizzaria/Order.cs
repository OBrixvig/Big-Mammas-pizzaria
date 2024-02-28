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

        private int _orderId = 0;
        private double _totalOrderPrice;
        private DateTime _date;
        static int _idCounter;

        private bool _discount = false;

        private List<PizzaCreator> _pizzaList = new List<PizzaCreator>();
        // alt ++


        public Order(bool club)
        {
            _orderId += ++_idCounter;
            Date = DateTime.Now;
            _totalOrderPrice = 0;
            _discount = club;
        }

        //Add pizza methode
        public void AddPizzaToList(PizzaCreator pizza)
        {
            _pizzaList.Add(pizza);
            _totalOrderPrice += pizza.PizzaPrice;
        }

        //ToString Method
        public override string ToString()
        {
            StringBuilder sB = new StringBuilder();
            sB.AppendLine("\n" + "Your order: ");
            foreach (PizzaCreator pizza in PizzaList)
            {
                sB.AppendLine(pizza.ToString());
            }
            sB.AppendLine("Comments: " + _commentMaker.PizzaComment + "\n" + "\n" + "Total Price: " + _totalOrderPrice + ",-" + "\n" + "ordre-id " + _orderId + "\n");
            sB.AppendLine("date " + Date.ToString("dd-MM-yyyy :  " + "\n" + "kl: HH:mm " + "\n"));
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
        public double TotalPrice
        {
            get { return _discount ? _totalOrderPrice * 0.8 : _totalOrderPrice; }
        }

        public Menu menu
        {
            get { return _menu; }
        }
        public CommentMaker Comment
        {
            get { return _commentMaker; }
        }
        public List<PizzaCreator> PizzaList
        {
            get { return _pizzaList; }
        }


    } // public double ClubDiscount()
      // {
      //     if (Order.TotalPrice >= 200) ;
      //     {
      //         return Order.TotalPrice *= 0.80;
      //     }
}
