using lab8_Iterator.Menus.Iterators;
using System.Collections;

namespace lab8_Iterator.Menus
{
    internal class TiraspolRestaurant : IteratorAggregate
    {
        private List<MenuItem> _items = new List<MenuItem>();

        public List<MenuItem> GetItems()
        {
            return _items;
        }

        public void AddItem(MenuItem item)
        {
            _items.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new TiraspolMenuIterator(this);
        }
    }
}
