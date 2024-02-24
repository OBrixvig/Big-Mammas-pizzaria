using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Big_Mammas_pizzaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Jans Henrik", "gangsterperson@gangstermail.com", "20202020", "Farligvej 26.");
            Customer customer2 = new Customer("Poul Magnussen", "Musik123@hotmail.com", "12123344", "Nodegade 31. 7. tv.");
            Customer customer3 = new Customer("sad man", "Tromme12@gmail.com", "20201111", "sløjseparken 31. 2. th.");


            Console.WriteLine(customer1.Order.menu);
            customer1.Order.menu.nr1.AddTopping("Extra Ost");

            Console.WriteLine(customer1.Order.menu.nr1);

            customer1.Order.AddPizzaNr1();
            customer1.Order.AddPizzaNr2();
            customer1.Order.AddPizzaNr3();

            customer1.Order.Comment.AddPizzaComment("Can i plz get my pizza with Xtra thick crust");

            Console.WriteLine(customer1);

            Console.ReadKey(false);
            Console.Clear();

            customer2.Order.AddPizzaNr1();
            customer2.Order.AddPizzaNr2();
            customer2.Order.AddPizzaNr3();

            Console.WriteLine(customer2.Order);

            Console.ReadKey(false);
            Console.Clear();

            customer3.CustomerClub.order.AddPizzaNr3();
            customer3.CustomerClub.order.AddPizzaNr2();
            customer3.CustomerClub.order.AddPizzaNr3();
            customer3.CustomerClub.order.AddPizzaNr3();
            Console.WriteLine(customer3.CustomerClub.order);

            customer3.CustomerClub.order.ClubDiscount();

            Console.WriteLine(customer3.CustomerClub.order);

            Console.ReadKey(false);
           
        }
    }
}
