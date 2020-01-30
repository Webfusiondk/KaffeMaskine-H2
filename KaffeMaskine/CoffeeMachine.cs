using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine
{
    abstract class CoffeeMachine : Machine
    {
        public bool hasfilter = false;

        public abstract string BrewCoffee(Bevearges bevearges, bool hasFilter);

        public string AddWater()
        {
            
            return "Adding water to the container";
        }

        public abstract string AddCoffee(Bevearges bevearges, bool hasfilter);


        public abstract string TakeProduct();

    }
}
