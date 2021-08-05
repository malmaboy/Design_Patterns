using System.Collections.Generic;

namespace Composite_Pattern
{
    public class PancakeHouseMenu 
    {
        private List<MenuItem> menuItems;
        private List<IMenuItem> iMenuItens;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            iMenuItens = new List<IMenuItem>();
            
            // Each menu item is added to the list
            
            AddItem("K&G's Pancake", "Pancakes with fried eggs, sausage",false, 2.99);
            AddItem("Regular Pancake Beakfast", "Pancakes with scramble eggs and toast", false, 2.99);
            AddItem("blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles with choice of blueberries or strawberries", true , 3.59);
            
            
            
        }


        public void AddItem(string name, string description, bool vegetarian, double price )
        {
            MenuItem menuItem =
                new MenuItem(name, description, vegetarian, price);

            menuItems.Add(menuItem);
        }
        
        // One way to get MenuItems
        public List<MenuItem> GetMenuItems()
        {
            return menuItems;
        }

        /// OTHER IMPORTANT METHODS TO BE HERE


        public void RemoveItem(MenuItem menuItem)
        {
            menuItems.Remove(menuItem);
        }
    }
}