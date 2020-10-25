using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeemachine
{
    class CoffeeStore
    {
        #region Member
        private double _pricePerKg;
        #endregion

        #region Constructor
        public CoffeeStore(double price)
        {
            PricePerKg = price;
        }
        #endregion

        #region Property
        public double PricePerKg {
            get { return _pricePerKg; }
            set
            {
                if (value >= 5 && value <= 30)
                {
                    _pricePerKg = value;
                }
                else if (value < 5)
                {
                    _pricePerKg = 5;
                }
                else if (value > 30)
                {
                    _pricePerKg = 30;
                }
            } 
        }
        #endregion

        #region Methods
        public double BuyCoffee(Coffeemachine machine, double amount)
        {
            double usedBeans = machine.MakeCoffee(amount, 5);
            double price = usedBeans * _pricePerKg;

            return price;
        }
        #endregion
    }
}
