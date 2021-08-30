using System;

namespace Strategy_Pattern
{
    /// <summary>
    /// New Design with Pattern
    /// </summary>
    public class GumballMachine2
    {
        // All the states
        private State soldOutState;
        private State noQuarterState;
        private State hasQuarterState;
        private State soldState;
        
        private State state;
        private int count;
        
        // readonly properties 
        public State HasQuarterState => hasQuarterState;
        public State NoQuarterState => noQuarterState;
        public State SoldOutState => soldOutState;
        public State SoldState => soldState;

        public int GetCount => count;

        public GumballMachine2(int _numberGumballs)
        {
            count = 0;
            count = _numberGumballs;
            
            // Created State Instances
            hasQuarterState = new HasQuarterState(this);
            noQuarterState = new NoQuarterState(this);
            soldState = new Soldstate(this);
            soldOutState = new SoldOutState(this);
        }

        public void SetState(State _state)
        {
            state = _state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count > 0)
                count = count - 1;
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void TurnCrack()
        {
            state.TurnCrank();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
            
        }



    }
    
    
    
}