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
        private string _order;

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
            string INFO = ($"Name:{_name} Email: {_email} Phone : {_phone} Adress: {_address}");

            return INFO;
        }

        // Metoder
        //public void MakeOrder(string pizza, string pizza1, string pizza2)
        //{
        //    _order = pizza + pizza1 + pizza2;
        //}


       

       

















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
        public string Order
        {
            get { return _order; }
        }

        

       
       
    }
}
