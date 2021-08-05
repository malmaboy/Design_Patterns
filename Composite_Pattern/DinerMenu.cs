using System;

namespace Composite_Pattern
{
    public class DinerMenu
    {
        private const int MaxItems = 6;
        private int numberOfItems;
        private MenuItem[] menuItems;
        
        public DinerMenu()
        {
            numberOfItems = 0;

            menuItems = new MenuItem[MaxItems];
            
            // Items Added
            AddItem("Vegetarian BLT", "Fake Bacon with lettuce & tomato on whole wheat",true, 2.99);
            AddItem("Soup of the day", "Soup with a side of potato salad", false, 2.99);
        }

         /// <summary>
         /// Add item to the  menu list
         /// it also checks to make sure we haven't hit the menu size limit 
         /// </summary>
         /// <param name="name"></param>
         /// <param name="description"></param>
         /// <param name="vegetarian"></param>
         /// <param name="price"></param>
        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem =
                new MenuItem(name, description, vegetarian, price);
            
            // Keep the menu under a certain size (6) 
            if(numberOfItems >= MaxItems)
                Console.WriteLine("Sorry, menu is full! Can't add item to menu.\n");
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems = numberOfItems + 1;
            }
                
                
            
        }
        
        // Other way to get menu Items
        public MenuItem[] GetMenuItems() => menuItems;

        // Other Methods... 
    }
}