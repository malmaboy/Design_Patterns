using System;

namespace Strategy_Pattern
{
    public class Soldstate : State
    {
        private GumballMachine2 gumballMachine2;
        
        public Soldstate(GumballMachine2 _gumballMachine2)
        {
            gumballMachine2 = _gumballMachine2;
            
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball.\n");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank\n");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another  gumball.\n");
        }
        
        //  We're in the SoldState, which means the customer paid.
        // So, we first need to ask the machine to release a gumball

        public void Dispense()
        {
            gumballMachine2.ReleaseBall();
            if(gumballMachine2.GetCount > 0)
                gumballMachine2.SetState(gumballMachine2.NoQuarterState);
            else
            {
                Console.WriteLine("Oops, out of gumballs\n");
                gumballMachine2.SetState(gumballMachine2.SoldOutState);
            }
        }
    }
}