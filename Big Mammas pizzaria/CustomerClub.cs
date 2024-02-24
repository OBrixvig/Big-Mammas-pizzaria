using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public class CustomerClub
    {
        public int _customerId;
        public int _idCounter;

        //Making so a Cuttomer in customerclub can order
        Order _order = new Order();

        //Setting the properties
        public CustomerClub()
        {
            _customerId = _idCounter;
            _idCounter++;
        }
        // Discount methode, only works if customer order with customerclub
        public double ClubDiscount()
        {
            if (Order.TotalPrice >= 200) ;
            {
                return Order.TotalPrice *= 0.80;
            }
        }
        public int clubId
        {
            get { return _customerId; }
        }
        public Order Order { get { return _order; } }
    }

}
