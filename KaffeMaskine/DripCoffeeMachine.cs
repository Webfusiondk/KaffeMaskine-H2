using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine
{
    class DripCoffeeMachine : CoffeeMachine
    {
        public override string AddCoffee(Bevearges bevearges, bool hasfilter)
        {
            if (hasfilter == true)
            {
                return "Adding " + bevearges.Name + " to the machine";
            }
            return null;
        }

        public override string BrewCoffee(Bevearges bevearges, bool hasFilter)
        {
            return AddWater() + "\n" + AddCoffee(bevearges, hasFilter) + "\n" + TakeProduct() + "\n" + "The Coffe is done.";
        }


        public override string TakeProduct()
        {
            return "Pleas take the product";
        }
    }
}
