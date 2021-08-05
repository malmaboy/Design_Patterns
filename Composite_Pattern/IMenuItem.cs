namespace Composite_Pattern
{
    /// <summary>
    /// Design Uniformity
    /// </summary>
    public interface IMenuItem
    {
        public string Name { get;  set; }
        public string GetDescription { get; set; }
        public bool IsVegetarian { get; set; }
        public double GetPrice { get; set; }
    }
}