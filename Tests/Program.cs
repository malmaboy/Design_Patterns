using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Tests
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
            Mountain mountain;
            mountain = new Mountain();
            Console.WriteLine(mountain.MovementCost);
        }

        
    }
}
