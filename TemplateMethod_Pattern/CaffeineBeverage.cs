using System;

namespace TemplateMethod_Pattern
{
    public abstract class CaffeineBeverage
    {
        /// <summary>
        /// Method will be used to make both Tea and Coffee 
        /// </summary>
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        // Because Coffee and tea can handle these methods
        public abstract void  Brew();
        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water.\n");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup.\n");
        }
    }
}