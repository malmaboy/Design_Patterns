using System;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program;

            program = new Program();

            program.RunMethods();
        }


        private void RunMethods()
        {
            // Create a duck
            IDuck duck = new MallardDuck();
            
            // Create a turkey 
            ITurkey turkey = new WildTurkey();
            // Create a turkey adapter, which makes it look like a duck
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            // Print Turkey
            Console.WriteLine("turkey says...");
            turkey.Gobble();
            turkey.Fly();
            
            // Print Duck
            Console.WriteLine("\n The Duck says....");
            DuckSays(duck);
            
            // Print Adapter
            Console.WriteLine("The turkey adapter says...\n");
            DuckSays(turkeyAdapter);
            
            
            
            
            
            // Other way of printing
            // Adapter
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
        }


        private void DuckSays(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
