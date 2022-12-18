﻿namespace lab8_Iterator.Menus.Iterators
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
            return _menu.getItems()[_position];
        }

        public override bool MoveNext()
        {
            int updatedPosition = ++_position;

            if (updatedPosition >= 0 && updatedPosition < _menu.getItems().Count)
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