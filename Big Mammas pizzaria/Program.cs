using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Big_Mammas_pizzaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Customer customer1 = new Customer("Jans Henrik", "gangsterperson@gangstermail.com", "20202020", "Farligvej 26.", false);
            Customer customer2 = new Customer("Poul Magnussen", "Musik123@hotmail.com", "12123344", "Nodegade 31. 7. tv.", false);
            Customer customer3 = new Customer("sad man", "Tromme12@gmail.com", "20201111", "sløjseparken 31. 2. th.", true);
           
            Console.WriteLine(menu);

            customer1.CreateOrder();
            customer1.Order.menu.nr1.AddTopping("Extra Ost");

            Console.ReadKey(false);
            Console.Clear();

            customer1.Order.AddPizzaToList(customer1.Order.menu.nr1);
            customer1.Order.AddPizzaToList(customer1.Order.menu.nr2);
            customer1.Order.AddPizzaToList(customer1.Order.menu.nr3);
            customer1.Order.PizzaList[2].AddTopping("Pepper");
            customer1.Order.PizzaList[1].AddTopping("extra ost");
            customer1.Order.Comment.AddPizzaComment("Can i plz get my pizza with Xtra thick crust");

            Console.WriteLine(customer1);

            Console.ReadKey(false);
            Console.Clear();

            customer2.CreateOrder();
            customer2.Order.AddPizzaToList(new PizzaCreator("lågsus","Kebab, dressing, fisk",120));
            customer2.Order.AddPizzaToList(menu.nr3);
            customer2.Order.AddPizzaToList(menu.nr1);
            customer2.Order.PizzaList[1].AddTopping("smør");
            customer2.Order.Comment.AddPizzaComment("Jeg har desværre ingen elevator eller dør, så travl op på min altan");
            
            Console.WriteLine(customer2);

            Console.ReadKey(false);
            Console.Clear();

            customer3.CreateOrder();
            customer3.Order.AddPizzaToList(customer3.Order.menu.nr1);
            customer3.Order.AddPizzaToList(customer3.Order.menu.nr2);
            customer3.Order.AddPizzaToList(customer3.Order.menu.nr3);
            customer3.Order.AddPizzaToList(customer3.Order.menu.nr1);
            
            Console.WriteLine(customer3);

            Console.ReadKey(false);
        }
    }
}
