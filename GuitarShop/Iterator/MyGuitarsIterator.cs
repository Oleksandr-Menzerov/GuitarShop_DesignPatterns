using GuitarShop.Component;

namespace GuitarShop.Iterator
{
    public class MyGuitarsIterator : IIterator
    {
        private Guitar[] _myGuitars;
        private int _current;
        public MyGuitarsIterator(Guitar[] _myGuitars)
        {
            this._myGuitars = _myGuitars;
            _current = 0;
        }

        public int Count()
        {
            return _myGuitars.Length;
        }

        public Guitar CurrentItem()
        {
            return _myGuitars[_current];
        }

        public void First()
        {
            _current = 0;
        }
        public Guitar GetElementAt(int index)
        {
            return _myGuitars[index];
        }

        public bool IsDone()
        {
            return _current >= _myGuitars.Length;
        }

        public Guitar Next()
        {
            return _myGuitars[_current++];
        }
    }
}
