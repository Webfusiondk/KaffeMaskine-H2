using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine
{
    class MultiBrew : CoffeeMachine
    {
        public override string AddCoffee(Bevearges bevearges, bool hasfilter)
        {
            if (hasfilter == false)
            {
                return "Adding " + bevearges.Name + " to the machine";
            }
            if (hasfilter == true)
            {
                return "Adding " + bevearges.Name + " to the machine";
            }
            return null;
        }

        //Brew Tea
        public override string BrewCoffee(Bevearges bevearges, bool hasFilter)
        {
            return AddWater() + "\n" + AddCoffee(bevearges, hasFilter) + "\n" + TakeProduct() + "\n" + "The " + bevearges.Name + " is done.";

        }

        public override string TakeProduct()
        {
            return "Pleas take the product";
        }
    }
}
