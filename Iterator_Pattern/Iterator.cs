using System.Collections;

namespace Iterator_Pattern
{
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();
        
        // Returns the key of current element
        public abstract int Key();
        
        // Returns current element 
        public abstract object Current();
        
        // Move forward to next element
        public abstract bool MoveNext();
        
        // Rewind the Iterator to the first element
        public abstract void Reset();
    }
}