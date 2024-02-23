using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    internal class CustomerClub
    {
        public int _customerId;
        public int _idCounter;
        public CustomerClub()
        {
            _customerId = _idCounter;
            _idCounter ++;
        }
        public int clubId
        { 
            get { return _customerId; } 
        }

    }

}
