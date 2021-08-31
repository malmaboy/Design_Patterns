using System;
using System.Collections.Generic;

namespace SubclassSandbox_Pattern
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
            // A list that will store all superpowers
            List<SuperPower> superPowers;
            superPowers = new List<SuperPower>();
            
            superPowers.Add(new SkyLaunch());
            superPowers.Add(new GroundDive());
            
            // Activate each superpower each update
            for (int i = 0; i < superPowers.Count; i++)
            {
                superPowers[i].Activate();
            }
        }
    }
}
