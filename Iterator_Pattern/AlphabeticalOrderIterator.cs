
namespace Iterator_Pattern
{
    // Concrete Iterators implement various traversal algorithms. These classes
    // store the current traversal position all times
    public class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection collection;
        private int position;
        private bool reverse;
        
        // Stores the current traversal position. An iterator may have a lot of
        // other fields for storing iterator state, especially whe it is 
        // supposed to work with a particular kind of collection
        public AlphabeticalOrderIterator(WordsCollection _collection,
            bool _reverse = false)
        {
            
            reverse = false;
            position = -1;

            collection = _collection;
            reverse = _reverse;

            if (reverse)
                position = collection.GetItems().Count;
        }

        public override object Current()
        {
            return collection.GetItems()[position];
        }

        public override int Key()
        {
            return position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = position + (reverse ? -1 : 1);

            if (updatedPosition >= 0 &&
                updatedPosition < collection.GetItems().Count)
            {
                position = updatedPosition;
                return true;
            }
            
            
            return false;
            
        }
        public override void Reset()
        {
            position = reverse ? collection.GetItems().Count -1 : 0;
        }
    }
}