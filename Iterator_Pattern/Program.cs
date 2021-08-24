using System;

namespace Iterator_Pattern
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
            // The client code may or may not know about the Concrete Iterator
            // or collection classes, depeding on the level of indirection you
            // want to keep in your program 
            WordsCollection collection = new WordsCollection();
            
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight Traversal");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\n Reverse traversal");

            collection.ReverseDirection();
            foreach (var element in collection)
            {
                Console.WriteLine(element);
                
            }
            
        }
    }
}
