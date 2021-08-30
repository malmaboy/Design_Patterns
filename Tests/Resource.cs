namespace Tests
{
    public class Resource
    {
        public float Cost { get; }
        public string Name { get;  }

        public Resource(float _cost, string _name)
        {
            Cost = _cost;
            Name = _name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}