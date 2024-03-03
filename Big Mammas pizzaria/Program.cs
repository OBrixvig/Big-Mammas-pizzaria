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
            Customer customer2 = new Customer("Poul Magnussen", "Musik123@hotmail.com", "12123344", "Nodegade 31. 7. tv.", true);
            Customer customer3 = new Customer("sad man", "Tromme12@gmail.com", "20201111", "sløjseparken 31. 2. th.", true);
           
            //menuen pizza osv.
            Console.WriteLine(menu);

            // customer1 order begins
            customer1.CreateOrder();

            Console.ReadKey(false);
            Console.Clear();

            customer1.Order.AddPizzaToList(customer1.Order.menu.nr1);
            customer1.Order.AddPizzaToList(customer1.Order.menu.nr2);
            customer1.Order.AddPizzaToList(customer1.Order.menu.nr3);
            customer1.Order.PizzaList[2].AddTopping("extra Pepper");
            customer1.Order.PizzaList[1].AddTopping("extra ost");
            customer1.Order.AddComment("Can i plz get my pizza with Xtra thick crust");

            Console.WriteLine(customer1);
            // customer1 order ends
            
            Console.ReadKey(false);
            Console.Clear();

            //customer2 order begins
            customer2.CreateOrder();
            customer2.Order.AddPizzaToList(new PizzaCreator("lågsus","Kebab, dressing, ost & tomat",120));
            customer2.Order.AddPizzaToList(menu.nr3);
            customer2.Order.AddPizzaToList(menu.nr1);
            customer2.Order.PizzaList[1].AddTopping("extra smør");
            customer2.Order.AddComment("Jeg har desværre ingen elevator, trappe eller dør, så du er nød til at kravle op på min altan");
            
            Console.WriteLine(customer2);
            // customer2 order ends

            Console.ReadKey(false);
            Console.Clear();

            //customer3 order begins
            customer3.CreateOrder();
            customer3.Order.AddPizzaToList(menu.nr1);
            customer3.Order.AddPizzaToList(menu.nr2);
            customer3.Order.AddPizzaToList(menu.nr3);
            customer3.Order.AddPizzaToList(menu.nr1);
            customer3.Order.AddComment("Kunne godt tænke mig at alle pizzerne var i samme æske");
            
            Console.WriteLine(customer3);
            // customer3 order ends

            Console.ReadKey(false);

        }
    }
}
