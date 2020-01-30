using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffeMaskine
{
    class Program
    {
        static CoffeeMachine coffeDripper = new DripCoffeeMachine();
        static CoffeeMachine multiBrew = new MultiBrew();
        static Bevearges blackCoffee = new Coffee("Dark Thoughts");
        static Bevearges Tea = new Tea("Greay Eal Tea");
        static Bevearges Espresso = new Coffee("Espresso");
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            string userinputString = "";
            while (true)
            {
                Console.WriteLine("Type 1 to brew coffee");
                Console.WriteLine("Type 2 to brew Tea");
                Console.WriteLine("Type 3 to brew Espresso");
                int userinput = Convert.ToInt32(Console.ReadLine());
                switch (userinput)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(coffeDripper.TurnOn());
                        Console.WriteLine("Would you like to add filter?");
                        userinputString = Console.ReadLine().ToLower();
                        if (userinputString == "yes")
                            coffeDripper.hasfilter = true;
                        Console.WriteLine(coffeDripper.BrewCoffee(blackCoffee,coffeDripper.hasfilter));
                        Console.WriteLine(coffeDripper.TurnOff());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(multiBrew.TurnOn());
                            multiBrew.hasfilter = false;
                        Console.WriteLine(multiBrew.BrewCoffee(Tea,multiBrew.hasfilter));
                        Console.WriteLine(multiBrew.TurnOff());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(multiBrew.TurnOn());
                        multiBrew.hasfilter = true;
                        Console.WriteLine(multiBrew.BrewCoffee(Espresso, multiBrew.hasfilter));
                        Console.WriteLine(multiBrew.TurnOff());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
