using System;
using System.Security.Cryptography;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            
            program.Run();
        }

        private void Run()
        {
            GumballMachine gumballMachine;
            gumballMachine = new GumballMachine(5);
            
            // Print the state machine
            Console.WriteLine(gumballMachine);
            
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);
            
            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);
            
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();
            
            
            Console.WriteLine(gumballMachine);
            
            
            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);


        }
    }
}
