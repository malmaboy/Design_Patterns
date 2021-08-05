namespace Decorator_Pattern
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public abstract  double Cost();

        public string GetDesciption()
        {
            return description;
        }

    }
}