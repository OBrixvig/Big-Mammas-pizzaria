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
            //Opretter menuen
            MenuAdministration menu = new MenuAdministration();
            //Så møder big mamma på arbejde
            CustomerAdministation BigMammaAdmin = new CustomerAdministation();
                          
            //menuen pizza osv.
            Console.WriteLine(menu);

            Console.ReadKey(false);
            Console.Clear();
            // customer1 order begins
            Customer customer1 = new Customer("Jans Henrik", "gangsterperson@gangstermail.com", "20202020", "Farligvej 26.", false);
            BigMammaAdmin.AddCustomerToList(customer1);
            // Customer begins order
            customer1.CreateOrder();
            customer1.Order.AddPizzaToList(menu.MenuList[0]);
            customer1.Order.AddPizzaToList(menu.MenuList[1]);
            customer1.Order.AddPizzaToList(menu.MenuList[2]);
            customer1.Order.AddPizzaToList(menu.MenuList[2]);
            customer1.Order.ReciveAllItemsPizzaList();
            Console.ReadKey(false);

            // Customer removes item
            customer1.Order.RemovePizzaFromList(customer1.Order.PizzaList[3]);
            customer1.Order.ReciveAllItemsPizzaList();
            Console.ReadKey(false);
            // Customer Add xtra toppings to pizza                                               Virker ikke :/
            customer1.Order.AddXtraTopping(customer1.Order.PizzaList[0],"Ekstra Pepper");
            customer1.Order.AddXtraTopping(customer1.Order.PizzaList[1], "Ekstra Ost");
            customer1.Order.AddComment("Må jeg godt få min pizza med ekstra tyk skorpe");
            //customer Removes item from order
            Console.WriteLine(customer1);

            // customer1 order ends
            Console.ReadKey(false);
            Console.Clear();

            //Customer 2 uses the app
            Customer customer2 = new Customer("Poul Magnussen", "Musik123@hotmail.com", "12123344", "Nodegade 31. 7. tv.", true);
            BigMammaAdmin.AddCustomerToList(customer2);

            BigMammaAdmin.CreatePizzaToMenuList("lågsus", "Kebab, dressing, ost & tomat", 120);
            //customer2 order begins
            customer2.CreateOrder();
            customer2.Order.AddPizzaToList(menu.MenuList[3]);
            customer2.Order.AddPizzaToList(menu.MenuList[1]);
            customer2.Order.AddPizzaToList(menu.MenuList[4]);
            customer2.Order.AddXtraTopping(customer2.Order.PizzaList[0], "Ekstra smør");
            customer2.Order.AddComment("Jeg har desværre ingen elevator, trappe eller dør, så du er nød til at kravle op på min altan");

            Console.WriteLine(customer2);

            // customer2 order ends
            Console.ReadKey(false);
            Console.Clear();

            //customer3 enter the shop
            Customer customer3 = new Customer("sad man", "Tromme12@gmail.com", "20201111", "sløjseparken 31. 2. th.", true);
            BigMammaAdmin.AddCustomerToList(customer3);

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
            BigMammaAdmin.ReciveAllCustomerFromList();

            BigMammaAdmin.ReciveCustomerFromList("Jansen Heincik");

            BigMammaAdmin.UpdateCustomerName(customer1, "Jansen Heincik");

            BigMammaAdmin.AddCustomerToList(new Customer("Mr. Jeg Kigger bare", "ErUdePåEnGåTur@gmail.com", "12345678", "Hamudepådenbådder 26.", false));
            BigMammaAdmin.ReciveCustomerFromList("Jansen Heincik");

            Console.WriteLine();
            Console.ReadKey(false);
        }
    }
}
