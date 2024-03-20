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
        
        private OrderAdministration _order;
        public Customer(string name, string email, string phone, string address, bool customerClub) 
        {
            _name = name;
            _email = email;
            _phone = phone;
            _address = address;
            _clubmember = customerClub;
        }
       

        //ToString Methode
        public override string ToString()
        {
            string customerInfo = ($"Navn: {_name} \nEmail: {_email} \nMobil: {_phone} \nAdresse: {_address} \n{_order}");
            return customerInfo;
        }
         
        //making my CreateOrder Method
        public void CreateOrder()
        {
            _order = new OrderAdministration(_clubmember) ;
        }
        public void DeleteOrder()
        {
            _order.PizzaList.Clear();
        }

        // Making properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        public bool CustomerClub
        {
            get { return _clubmember; }
        }
        public OrderAdministration Order { get { return _order; } }
    }
}
