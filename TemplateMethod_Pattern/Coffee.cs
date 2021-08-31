using System;

namespace TemplateMethod_Pattern
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter.\n");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk.\n");
        }
    }
}