using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeemachine
{
    class Coffeemachine
    {
        #region Member
        private double _maxWater = 2.5, _maxBeans = 2.5;
        #endregion

        #region Constructor
        public Coffeemachine()
        {
            Water = 1;
            Beans = 0.2;
            TotalAmountOfCoffeeProduced = 1;
        }
        #endregion

        #region Property
        public double Water { get; private set; }
        public double Beans { get; private set; }
        public double TotalAmountOfCoffeeProduced { get; private set; }
        #endregion

        #region Methods
        public double RefillWater(double amount)
        {
            if (amount + Water <= _maxWater)
            {
                Water += amount;
                return amount;
            }
            else
            {
                double waterDifference = _maxWater - Water;
                Water = _maxWater;
                return waterDifference;
            }
        }
        public double RefillBeans(double amount)
        {
            if (amount + Beans <= _maxBeans)
            {
                Beans += amount;
                return amount;
            }
            else
            {
                double beanDifference = _maxBeans - Beans;
                Beans = _maxBeans;
                return beanDifference;
            }
        }
        //x(coffee)*1 + x(water)*relationCB = totalamount
        //x(1+relationCB) = totalamount
        //x = totalamount/(1+relationCB)
        public double MakeCoffee(double amount, double relationCoffeeBeans)
        {
            double waterAmount = relationCoffeeBeans * (amount / (1 + relationCoffeeBeans));
            double beansAmount = amount / (1 + relationCoffeeBeans);

            if ((amount / (1 + relationCoffeeBeans) > Beans))
            {
                Console.WriteLine("Too much Beans would be used, process has been canceled");
                return 0;
            }
            else if (relationCoffeeBeans * (amount / (1 + relationCoffeeBeans)) > Water)
            {
                Console.WriteLine("Too much Water would be used, process has been canceled");
                return 0;
            }
            else if (beansAmount > Beans || waterAmount > Water)
            {
                Console.WriteLine("Too much Water and Beans would be used, process has been canceled");
                return 0;
            }
            else
            {
                Water -= waterAmount;
                Beans -= beansAmount;
                TotalAmountOfCoffeeProduced += waterAmount + beansAmount;

                Console.WriteLine("Total coffee produced: " + TotalAmountOfCoffeeProduced +"kg");

                return beansAmount;
            }
        }
        #endregion
    }
}
