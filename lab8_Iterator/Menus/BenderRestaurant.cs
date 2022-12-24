using lab8_Iterator.Menus.Iterators;
using System.Collections;

namespace lab8_Iterator.Menus
{
    internal class BenderRestaurant : IteratorAggregate
    {
        private MenuItem[] _items = new MenuItem[] { };

        private int length = 0;

        public MenuItem[] GetItems()
        {
            return _items;
        }

        public void AddItem(MenuItem item)
        {
            Array.Resize(ref _items, ++length);
            _items[length - 1] = item;
        }

        public override IEnumerator GetEnumerator()
        {
            return new BenderMenuIterator(this);
        }
    }
}
