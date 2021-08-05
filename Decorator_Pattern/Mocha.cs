namespace Decorator_Pattern
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;

        }

        public override string GetDescription()
        {
            return beverage.GetDesciption() + ", + Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }
}