using System.Collections;
using System.Collections.Generic;

namespace Iterator_Pattern
{
    // Concrete Collections provide one or several methods for retrieving fresh
    // iterator instance, compatible with the collection class
    public class WordsCollection : IteratorAggregate
    {
        private List<string> collection;
        private bool direction;

        public WordsCollection()
        {
            collection = new List<string>();
            direction = false;
        }

        public void ReverseDirection()
        {
            direction = !direction;
        }

        public List<string> GetItems()
        {
            return collection;
        }

        public void AddItem(string item)
        {
            this.collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, direction);
        }
    }
}