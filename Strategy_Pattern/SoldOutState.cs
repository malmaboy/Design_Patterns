namespace Strategy_Pattern
{
    public class SoldOutState : State
    {
        private GumballMachine2 gumballMachine2;

        public SoldOutState(GumballMachine2 _gumballMachine2)
        {
            gumballMachine2 = _gumballMachine2;
        }

        public void InsertQuarter()
        {
            throw new System.NotImplementedException();
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