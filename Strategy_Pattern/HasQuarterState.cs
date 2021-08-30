using System;
using System.Threading.Channels;

namespace Strategy_Pattern
{
    public class HasQuarterState : State
    {
        private GumballMachine2 gumballMachine2;
        public HasQuarterState(GumballMachine2 _gumballMachine2)
        {
            gumballMachine2 = _gumballMachine2;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter.\n");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned. \n");
            gumballMachine2.SetState(gumballMachine2.NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned....\n");
            gumballMachine2.SetState(gumballMachine2.SoldState);
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispansed.\n");
        }
    }
}