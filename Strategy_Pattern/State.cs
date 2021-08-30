namespace Strategy_Pattern
{
    /// <summary>
    /// New Design with Pattern
    /// </summary>
    public interface State
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}