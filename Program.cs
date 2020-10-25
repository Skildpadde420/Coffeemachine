using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeemachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            
            Coffeemachine wmf = new Coffeemachine();
            Coffeemachine deLonghi = new Coffeemachine();

            wmf.RefillBeans(5);
            wmf.RefillWater(5);            
            deLonghi.RefillBeans(5);
            deLonghi.RefillWater(5);
            //wmf.MakeCoffee(4, 1.5);

            CoffeeStore starbucks = new CoffeeStore(26);

            price = Math.Round(starbucks.BuyCoffee(wmf, 0.4),2);
            Console.WriteLine("The price for the cup of coffee is: " + price + "$");

            price = Math.Round(starbucks.BuyCoffee(deLonghi, 1),2);
            Console.WriteLine("The price for the cup of coffee is: " + price + "$");

            Console.ReadKey();
        }
    }
}
