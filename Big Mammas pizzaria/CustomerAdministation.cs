using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Big_Mammas_pizzaria
{
    public class CustomerAdministation
    {

        private List<Customer> _customerList = new List<Customer>();
        private List<Customer> _clubMembersList = new List<Customer>();

        public CustomerAdministation()
        {

        }
        
        public void UpdateCustomerName(Customer customer, string name)
        {
            customer.Name = name ;
        }
        public void AddCustomerToList(Customer customer)
        {
            _customerList.Add(customer);

            if (customer.CustomerClub == true)
            {
                _clubMembersList.Add(customer);
            }
            
        }
        public void DeleteCustomerToList(Customer customer)
        {
            _customerList.Remove(customer);

            if (customer.CustomerClub == true)
            {
                _clubMembersList.Remove(customer);
            }
            
        }
        public void ReciveAllCustomerFromList()
        {
            foreach (Customer customer in _customerList)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("Clubmembers is following");
            foreach (Customer customerClub in _clubMembersList)
            {
                Console.WriteLine(customerClub);
            }
        }
        public void ReciveCustomerFromList(Customer Name)
        {
            _customerList.Contains(Name);
            Console.WriteLine(Name);
        }
        /* // Creating a customer                                                
        public void CreateCustomer()
        {
            
            string name;
            string email;
            string phone;
            string address;
            bool customerClub;

            string YesOrNo;
            Console.Write("Please enter your name");
            name = Console.ReadLine();

            Console.Write("Thanks for that, now enter a email:  ");
            email = Console.ReadLine();

            Console.Write("Thanks for that, now phone number:  ");
            phone = Console.ReadLine();
            Console.Write("Thanks for that, I just need your full address:  ");
            address = Console.ReadLine();
            Console.Write("Thanks one last thing, do you want to join our customer club? yes or?");

            YesOrNo = Console.ReadLine();
            if (YesOrNo.ToLower() == "yes")
            {
                customerClub = true;
            }
            else
            {
                customerClub = false;
            }
            Customer cus = new Customer(name, email, phone, address, customerClub);
        }
        */
        //ToString Method
        public override string ToString()
        {
            return base.ToString(); 
        }

        public List<Customer> CustomersList
        { get { return _customerList; } }
        public List<Customer> ClubMembers
        { get { return _clubMembersList; } }

       
    }
}
