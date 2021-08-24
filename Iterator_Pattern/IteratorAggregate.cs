using System.Collections;

namespace Iterator_Pattern
{
    public abstract class IteratorAggregate : IEnumerable
    {
        // Returns an Iterator or another IteratorAggregate for the implementing
        // object
        public abstract IEnumerator GetEnumerator();
    }
}