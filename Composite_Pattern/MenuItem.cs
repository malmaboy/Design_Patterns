namespace Composite_Pattern
{
    public class MenuItem
    {
        /// <summary>
        /// Design Safety type
        /// </summary>
        
        private string name;
        private string description;
        private bool vegetarian;
        private double price;
        
        public MenuItem(string _name, string _description, bool _vegetarian, double _price)
        {
            name = _name;
            description = _description;
            vegetarian = _vegetarian;
            price = _price;
        }
        
        /// <summary>
        /// Getter methods to let access the fields of the menu Item
        /// </summary>
        public string GetName => name;
        public string GetDescription => description;
        public bool IsVegetarian => vegetarian;
        public double GetPrice => price;
    }
}