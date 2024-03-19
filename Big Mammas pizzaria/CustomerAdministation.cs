using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Big_Mammas_pizzaria
{
    public class CustomerAdministation : MenuAdministration
    {

        private List<Customer> _customerList = new List<Customer>();
        private List<Customer> _clubMembersList = new List<Customer>();

        private string ReciveCustomer { get; set; }
        public CustomerAdministation()
        {
        }
        //Updates Customer Name
        public void UpdateCustomerName(Customer customer, string name)
        {
            customer.Name = name ;
        }
        //Sorts customers to the two list.
        public void AddCustomerToList(Customer customer)
        {
            _customerList.Add(customer);

            if (customer.CustomerClub == true)
            {
                _clubMembersList.Add(customer);
            }        
        }
        //Removes customers from the list
        public void DeleteCustomerToList(Customer customer)
        {
            _customerList.Remove(customer);

            if (customer.CustomerClub == true)
            {
                _clubMembersList.Remove(customer);
            }            
        }

        // Recives all the customers in the two list
        public void ReciveAllCustomerFromList()
        {
            foreach (Customer customer in _customerList)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("\n"+"PizzaKlubbens medlemmer er"+"\n");
            foreach (Customer customerClub in _clubMembersList)
            {
                Console.WriteLine(customerClub);         
            }
        //Looks for a customer and sends a error if not found
        }
        public void ReciveCustomerFromList(string customerName)
        {
            Customer nameSearch = _customerList.Find(customer => customer.Name == customerName);
            Console.WriteLine(nameSearch);
            if (nameSearch != null)
            {
                Console.WriteLine("Den person kender vi desværre ikke");
            }           
        }
        //tostring method
        public override string ToString()
        {
            return base.ToString(); 
        }
        // properties
        public List<Customer> CustomersList
        { get { return _customerList; } }
        public List<Customer> ClubMembers
        { get { return _clubMembersList; } }

       
    }
}
