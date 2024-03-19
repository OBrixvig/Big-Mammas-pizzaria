using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Big_Mammas_pizzaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuAdministration menu = new MenuAdministration();
            CustomerAdministation BigMama = new CustomerAdministation();
            Customer customer1 = new Customer("Jans Henrik", "gangsterperson@gangstermail.com", "20202020", "Farligvej 26.", false);
            BigMama.AddCustomerToList(customer1);
            
            Customer customer3 = new Customer("sad man", "Tromme12@gmail.com", "20201111", "sløjseparken 31. 2. th.", true);
            BigMama.AddCustomerToList(customer3);

            BigMama.AddCustomerToList(new Customer("Mr. Jeg Kigger bare", "ErUdePåEnGåTur@gmail.com", "12345678", "Farligvej 26.", false));

            BigMama.ReciveCustomerFromList(customer1);

            BigMama.ReciveAllCustomerFromList();

            BigMama.UpdateCustomerName(customer1,"Jansen Heincik");

            Console.WriteLine(customer1);
            //menuen pizza osv.
            Console.WriteLine(menu);

            Console.WriteLine(menu.MenuList[0]);
            Console.WriteLine(menu.MenuList[1]);

            // customer1 order begins

            Console.ReadKey(false);
            Console.Clear();
            customer1.CreateOrder();
            customer1.Order.AddPizzaToList(menu.MenuList[0]);
            customer1.Order.AddPizzaToList(menu.MenuList[1]);
           // customer1.Order.AddPizzaToList(customer1.Order.PizzaList[2]);
            customer1.Order.AddXtraTopping("extra Pepper");
            customer1.Order.PizzaList[1].AddTopping("extra ost");
            customer1.Order.AddComment("Can i plz get my pizza with Xtra thick crust");

            Console.WriteLine(customer1);
            // customer1 order ends

            Console.ReadKey(false);
            Console.Clear();

            //Customer 2 cumes along
            Customer customer2 = new Customer("Poul Magnussen", "Musik123@hotmail.com", "12123344", "Nodegade 31. 7. tv.", true);
            BigMama.AddCustomerToList(customer2);


            //customer2 order begins
            customer2.CreateOrder();
            customer2.Order.AddPizzaToList(new Pizza("lågsus", "Kebab, dressing, ost & tomat", 120));
            customer2.Order.AddPizzaToList(menu.MenuList[1]);
            customer2.Order.AddPizzaToList(menu.MenuList[2]);
            customer2.Order.PizzaList[1].AddTopping("extra smør");
            customer2.Order.AddComment("Jeg har desværre ingen elevator, trappe eller dør, så du er nød til at kravle op på min altan");

            Console.WriteLine(customer2);
            // customer2 order ends

            Console.ReadKey(false);
            Console.Clear();

            //customer3 order begins
            customer3.CreateOrder();
            customer3.Order.AddPizzaToList(menu.MenuList[1]);
            customer3.Order.AddPizzaToList(menu.MenuList[2]);
            customer3.Order.AddPizzaToList(menu.MenuList[0]);
            customer3.Order.AddPizzaToList(menu.MenuList[3]);
            customer3.Order.AddComment("Kunne godt tænke mig at alle pizzerne var i samme æske");
            
            Console.WriteLine(customer3);
            // customer3 order ends

             
            Console.ReadKey(false);

           
            Console.Clear();
            Console.WriteLine(customer3);
            
            

            Console.WriteLine();
            Console.ReadKey(false);
        }
    }
}
