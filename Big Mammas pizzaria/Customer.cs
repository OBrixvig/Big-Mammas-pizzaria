using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public class Customer
    {
        private string _name;
        private string _email;
        private string _phone;
        private string _address;

        Order _order = new Order();
        CustomerClub _clubId = new CustomerClub();
        public Customer(string name, string email, string phone, string adresse)
        {
            _name = name;
            _email = email;
            _phone = phone;
            _address = adresse;

        }
        //ToString Methode
        public override string ToString()
        {
            string INFO = ($"Name:{_name}{Environment.NewLine}Email: {_email}{Environment.NewLine}Phone : {_phone}{Environment.NewLine}Adress: {_address}");
            return INFO;
        }

        // Making properties
        public string Name
        {
            get { return _name; }
        }
        public string Email
        {
            get { return _email; }
        }
        public string Phone
        {
            get { return _phone; }
        }
        public string Address
        {
            get { return _address; }
        }
        public Order order
        { 
            get { return _order; } 
        }
        public CustomerClub CustomerClub
        { 
            get { return _clubId; } 
        }
    }
}
