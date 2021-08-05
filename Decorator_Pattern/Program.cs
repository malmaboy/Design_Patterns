using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            
            program.StarBuzzCoffee();
            
        }


        private void StarBuzzCoffee()
        {
            Beverage beverage;
            beverage = new Expresso();

            Console.WriteLine(beverage.GetDesciption() + "$" + beverage.Cost());

            Beverage beverage2;
            beverage2 = new DarkRoast();

            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage);

            Console.WriteLine(beverage2.GetDesciption() + "$" + beverage2.Cost());
            
        }
    }
}
