using GuitarShop.Component;

namespace GuitarShop.Iterator
{
    public class ShopGuitarsIterator : IIterator
    {
        private List<Guitar> _shopGuitars;
        private int _current;
        public ShopGuitarsIterator(List<Guitar> _shopGuitars)
        {
            this._shopGuitars = _shopGuitars;
            _current = 0;
        }

        public int Count()
        {
            return _shopGuitars.Count;
        }

        public Guitar CurrentItem()
        {
            return _shopGuitars.ElementAt(_current);
        }

        public void First()
        {
            _current = 0;
        }

        public Guitar GetElementAt(int index)
        {
            return _shopGuitars.ElementAt(index);
        }

        public bool IsDone()
        {
            return _current >= _shopGuitars.Count;
        }

        public Guitar Next()
        {
            return _shopGuitars.ElementAt(_current++);
        }
    }
}
