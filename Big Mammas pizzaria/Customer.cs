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

        //Making an Order :_order; so that i can make a method the creates order.
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
            string customerInfo = ($"Name:{_name} \n Email: {_email} \n Phone : {_phone} \n Adress: {_address} \n {_order}");

            return customerInfo;
        }

        //making my CreateOrder Method
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
