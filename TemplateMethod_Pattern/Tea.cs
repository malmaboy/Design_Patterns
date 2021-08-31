using System;

namespace TemplateMethod_Pattern
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea.\n");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon.\n");
        }
    }
}