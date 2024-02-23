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
       Customer customer3 = new Customer("Oliver Brixvig", "Oliverbrixvig@gmail.com", "2", "Ejboparken 31. 2. th.");

            customer1.order.menu.nr1.AddTopping("Extra Ost");
            

            customer1.order.AddPizzaNr1();
            customer1.order.AddPizzaNr2();
            customer1.order.AddPizzaNr3();

            Console.WriteLine(customer1.order);

            Console.WriteLine(customer1.order.menu.nr1.Name);

            Console.ReadKey();
            Console.Clear();

            customer2.order.AddPizzaNr1();
            customer2.order.AddPizzaNr2();
            customer2.order.AddPizzaNr3();

            Console.WriteLine(customer2.order);

            Console.ReadKey();
            Console.Clear();

            customer3.CustomerClub.order.AddPizzaNr3();
            customer3.CustomerClub.order.AddPizzaNr2();
            customer3.CustomerClub.order.AddPizzaNr3();
            customer3.CustomerClub.order.AddPizzaNr3();

            Console.WriteLine(customer3.CustomerClub.order);

            Console.ReadKey();
            Console.Clear();

        }
            

        
    }
}
