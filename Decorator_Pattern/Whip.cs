namespace Decorator_Pattern
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDesciption() + ", + Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.50;
        }
    }
}