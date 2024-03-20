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

            //Så møder big mamma på arbejde
            CustomerAdministation bigMammaAdmin = new CustomerAdministation();

            //Big mamma kunne godt tænke sig at få en ny pizza på menuen
            bigMammaAdmin.Menu.CreateNewPizzaToMenuList("LÅGSUS", "Kebab, dressing, ost & tomat", 88);

            //Big mamma sover i timen og tilføjer pizzen til menuen to gange
            bigMammaAdmin.Menu.CreateNewPizzaToMenuList("LÅGSUS", "Kebab, dressing, ost & tomat", 88);

            //menuen pizza osv.
            Console.WriteLine(bigMammaAdmin.Menu);

            Console.ReadKey(false);
            Console.Clear();
            // customer1 order begins
            Customer customer1 = new Customer("Jans Henrik", "gangsterperson@gangstermail.com", "20202020", "Farligvej 26.", false);
            bigMammaAdmin.AddCustomerToList(customer1);
            // Customer begins order
            customer1.CreateOrder();
            customer1.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[0]);
            customer1.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[1]);
            customer1.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[2]);
            customer1.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[2]);
            customer1.Order.ReciveAllItemsPizzaList();
            Console.ReadKey(false);
            Console.WriteLine();

            // Customer removes item
            customer1.Order.RemovePizzaFromList(customer1.Order.PizzaList[3]);
            customer1.Order.ReciveAllItemsPizzaList();
            Console.ReadKey(false);
            Console.Clear();

            // Customer Add xtra toppings to pizza   
            customer1.Order.AddXtraTopping(customer1.Order.PizzaList[0],"Ekstra Pepper");
            customer1.Order.AddXtraTopping(customer1.Order.PizzaList[1], "Ekstra Ost");
            customer1.Order.AddComment("Må jeg godt få min pizza med ekstra tyk skorpe");
            //customer Removes item from order
            Console.WriteLine(customer1);

            // customer1 order ends
            Console.ReadKey(false);
            Console.Clear();

            //Customer 2 is hungry
            Customer customer2 = new Customer("Poul Magnussen", "Musik123@hotmail.com", "12123344", "Nodegade 31. 7. tv.", true);
            bigMammaAdmin.AddCustomerToList(customer2);

            //customer2 order begins
            customer2.CreateOrder();
            customer2.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[0]);
            customer2.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[1]);
            customer2.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[2]);
            customer2.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[3]);
            customer2.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[4]);
            customer2.Order.AddXtraTopping(customer2.Order.PizzaList[0], "Ekstra smør");
            customer2.Order.AddComment("Jeg har desværre ingen elevator, trappe eller dør, så du er nød til at kravle op på min altan");

            Console.WriteLine(customer2);

            // customer2 order ends
            Console.ReadKey(false);
            Console.Clear();

            //customer3 enter the shop
            Customer customer3 = new Customer("sad man", "Tromme12@gmail.com", "20201111", "sløjseparken 31. 2. th.", true);
            bigMammaAdmin.AddCustomerToList(customer3);

            //customer3 order begins
            customer3.CreateOrder();
            customer3.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[1]);
            customer3.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[2]);
            customer3.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[0]);
            customer3.Order.AddPizzaToList(bigMammaAdmin.Menu.MenuList[3]);
            customer3.Order.AddComment("Kunne godt tænke mig at alle pizzerne var i samme æske");

            Console.WriteLine(customer3);
            // customer3 order ends

            Console.ReadKey(false);
            Console.Clear();

            Console.WriteLine("Så er dagen slut det har været stille dag gad vide hvor mange kunder der har været\n" +
                "samt hvad de har købt, og hvor mange har været en del af vores pizzaklub\n");

            bigMammaAdmin.ReciveAllCustomerFromList();

            Console.ReadKey(false);
            Console.Clear();

            Console.WriteLine("Ham " + customer1.Name + " han hed da faktisk noget andet Prøver lige at slå det andet navn op");

            bigMammaAdmin.ReciveCustomerFromList("Jansen Heincik");

            Console.WriteLine("hov han var der ikke, så skifter jeg lige hans navn");

            bigMammaAdmin.UpdateCustomerName(customer1, "Jansen Heincik");

            Console.WriteLine("Sådan nu prøver jeg lige at slå ham op igen");

           // bigMammaAdmin.AddCustomerToList(new Customer("Mr. Jeg Kigger bare", "ErUdePåEnGåTur@gmail.com", "12345678", "Hamudepådenbådder 26.", false));

            bigMammaAdmin.ReciveCustomerFromList("Jansen Heincik");

            Console.WriteLine();

            Console.ReadKey(false);
            Console.Clear();

            bigMammaAdmin.ReciveAllCustomerFromList();

            Console.WriteLine();
            Console.ReadKey(false);

            
        }
    }
}
