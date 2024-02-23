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

        Order _order = new Order();

        
        public CustomerClub()
        {
            _customerId = _idCounter;
            _idCounter ++;
        }
        public int clubId
        { 
            get { return _customerId; } 
        }
        public Order order { get { return _order; } }
    }

}
