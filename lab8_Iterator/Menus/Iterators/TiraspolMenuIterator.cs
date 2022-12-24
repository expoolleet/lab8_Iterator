namespace lab8_Iterator.Menus.Iterators
{
    internal class TiraspolMenuIterator : Iterator
    {
        private TiraspolRestaurant _menu;

        private int _position = -1;

        public TiraspolMenuIterator(TiraspolRestaurant menu)
        {
            _menu = menu;
        }

        public override MenuItem Current()
        {
            return _menu.GetItems()[_position];
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + 1;

            if (updatedPosition >= 0 && updatedPosition < _menu.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _position = 0;
        }
    }
}
