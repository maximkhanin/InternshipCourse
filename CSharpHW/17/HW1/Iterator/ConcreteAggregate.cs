using System.Collections;

namespace Iterator
{
    class ConcreteAggregate <T> : Aggregate
    {
        private readonly ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        public int Count => _items.Count;

        public object this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }
    }
}