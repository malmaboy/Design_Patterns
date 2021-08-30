using System;

namespace Strategy_Pattern
{
    public class NoQuarterState : State
    {
        private GumballMachine2 gumballMachine2;
        public NoQuarterState(GumballMachine2 _gumballMachine2)
        {
            gumballMachine2 = _gumballMachine2;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Your inserted a quarter.\n");
            gumballMachine2.SetState(gumballMachine2.NoQuarterState);
        }

        public void EjectQuarter()
        {
            throw new System.NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }

        public void Dispense()
        {
            throw new System.NotImplementedException();
        }
        
        
    }
}