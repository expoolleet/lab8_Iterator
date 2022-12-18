using System.Collections;

namespace lab8_Iterator.Menus.Iterators
{
    internal abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract bool MoveNext();

        public abstract void Reset();

        public abstract object Current();
    }

    internal abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
