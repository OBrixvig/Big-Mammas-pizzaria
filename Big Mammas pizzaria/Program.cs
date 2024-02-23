using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Big_Mammas_pizzaria
{
    public class Program
    {
        static void Main(string[] args)
        { // laver et par kunder, navn, email, adresse.
            Customer customer1 = new Customer("Jans Henrik", "gangsterperson@gangstermail.com", "20202020", "Farligvej 26.");
            Customer customer2 = new Customer("Poul Magnussen", "Musik123@hotmail.com", "12123344", "Nodegade 31. 7. tv.");
            Customer customer3 = new Customer("Oliver Brixvig", "Oliverbrixvig@gmail.com", "26725053", "Ejboparken 31. 2. th.");

            Console.WriteLine(customer1);
            Console.WriteLine(customer2);
            Console.WriteLine(customer3);

           // // pizza nr1 MAGARITA   
           // Pizza nr1 = new Pizza("MAGARITA", "TOMATO CHEESE", 69);
           // Console.WriteLine(nr1);
           //
           // // pizza nr.2 VESUVIO
           // Pizza nr2 = new Pizza("VESUVIO", "TOMATO CHEESE & HAM", 75);
           // Console.WriteLine(nr2);
           //
           // Console.WriteLine(nr1);
           //
           // // pizza nr3 CAPRICCIOSA
           // Pizza nr3 = new Pizza("CAPRICCIOSA", "TOMATO CHEESE HAM & MUSHROOMS", 80);
           // Console.WriteLine($"{nr3.Name} topping {nr3.PizzaTopping} {nr3.XtraTopping} totalt pizza price {nr3.PizzaPrice}");
           //
           // Console.ReadKey();
           // Console.Clear();
           //
           //
           // // opredtning af ordre
           // double totalPrice = nr1.PizzaPrice + nr2.PizzaPrice + nr3.PizzaPrice;
           //
           // Console.WriteLine(customer1);
           // Console.WriteLine($"Order {nr1}");
           // Console.WriteLine($"and a {nr2}");
           // Console.WriteLine($"and a {nr3}");
           //
           // Console.WriteLine($" totalprice: {totalPrice} dkk.");
           //
           // Order Cus1Order = new Order()
           // Console.ReadKey();


            Order frøste = new Order();

            

        }
            

        
    }
}
