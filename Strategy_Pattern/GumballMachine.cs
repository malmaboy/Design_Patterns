using System;

namespace Strategy_Pattern
{
    public class GumballMachine
    {
        // Various States
        private const int SOLD_OUT = 0;

        private const int NO_QUARTER = 1;

        private const int HAS_QUARTER = 2;

        private const int SOLD = 3;
        // Instance variable that hold the current state
        private int state;
        private int count;

        // Constructor
        public GumballMachine(int _count)
        {
            // Current state since the machine will be unfilled
            state = SOLD_OUT;
            // We have a second instance variable that
            // keeps track of the  number of gumballs
            // in the machine
            count = 0;

            count = _count;
            if (count > 0)
                state = NO_QUARTER;
            
            

        }
        
        // Actions method
        public void InsertQuarter()
        {
            if (state == HAS_QUARTER)
                Console.WriteLine("You can't insert another quarter.");
            else if (state == NO_QUARTER)
            {
                state = HAS_QUARTER;
                Console.WriteLine("You inserted a quarter.");
            }
            else if(state == SOLD_OUT)
                Console.WriteLine("You can't insert a quarter, the machine is sold out.");
            else if(state == SOLD)
                Console.WriteLine("Please wait, we're already giving you a gumball.");
        }

        public void EjectQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("Quarter returned.");
                state = NO_QUARTER;
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You haven't inserted a quarter.");
            }
            else if (state == SOLD)
            {
                Console.WriteLine("Sorry, you already turned the crank.");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet.");
            }
        }

        public void TurnCrank()
        {
            if(state == SOLD)
                Console.WriteLine("Turning twice doesn't get you another gumball!");
            else if(state == NO_QUARTER)
                Console.WriteLine("You turned but there's no quarter.");
            else if(state == SOLD_OUT)
                Console.WriteLine("You turned, but there are no gumballs");
            else if (state == HAS_QUARTER)
            {
                Console.WriteLine("You turned...");
                state = SOLD;
                Dispanse();
            }
        }

        public void Dispanse()
        {
            if (state == SOLD)
            {
                Console.WriteLine("A gumball comes rolling out the slot.");
                count = count - 1;
                if (count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs.");
                    state = SOLD_OUT;
                }
                else
                    state = NO_QUARTER;
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You need to pay first.");
            }
            else if(state == SOLD_OUT)
                Console.WriteLine("No gumball dispensed.");
            else if(state == HAS_QUARTER)
                Console.WriteLine("You need to turn the crank.");
        }
    }
}