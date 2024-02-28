using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        private bool _clubmember;

        Order _order;
        public Customer(string name, string email, string phone, string adresse, bool customerClub)
        {
            _name = name;
            _email = email;
            _phone = phone;
            _address = adresse;
            _clubmember = customerClub;
        }
        //ToString Methode
        public override string ToString()
        {
            string customerInfo = ($"Name:{_name}{Environment.NewLine}Email: {_email}{Environment.NewLine}Phone : {_phone}{Environment.NewLine}Adress: {_address}{Environment.NewLine}{_order}");

            return customerInfo;
        }

        public void CreateOrder()
        {
            _order = new Order(_clubmember);

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
        public Order Order
        {
            get { return _order; }
        }
        public bool CustomerClub
        {
            get { return _clubmember; }
        }
    }
}
