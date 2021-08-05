using System;
using System.Collections.Generic;

namespace Composite_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHERE ITERATOR ENTERS
            // Running all arrays 

            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            List<MenuItem> breakfast = pancakeHouseMenu.GetMenuItems();

            DinerMenu dinerMenu = new DinerMenu();
            MenuItem[] lunchItems = dinerMenu.GetMenuItems();
            
            // Uniformity Ex
           
            
            
            // Iterator
            // For breakfast( PancakeHouseMenu)
            foreach (var food in breakfast)
            {
                Console.WriteLine(food.GetName);
                Console.WriteLine(food.GetPrice);
                Console.WriteLine(food.GetDescription);
            }
            
            // Iterator 
            // For lunch Items
            foreach (var lunch in lunchItems)
            {
                Console.WriteLine(lunch.GetName);
                Console.WriteLine(lunch.GetPrice);
                Console.WriteLine(lunch.GetDescription);
            }
            
            // For Uniformity Ex
        }
    }
}
