using System;

namespace TemplateMethod_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            
            program.Run();
        }


        private void Run()
        {
            Coffee coffee;
            coffee = new Coffee();

            Tea tea;
            tea = new Tea();
            
            tea.PrepareRecipe();

            coffee.PrepareRecipe();
            
        }
    }
}
