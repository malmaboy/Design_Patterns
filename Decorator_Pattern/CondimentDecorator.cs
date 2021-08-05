namespace Decorator_Pattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public abstract string GetDescription();


    }
}