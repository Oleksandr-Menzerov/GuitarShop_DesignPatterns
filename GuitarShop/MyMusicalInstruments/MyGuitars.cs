using GuitarShop.Component;
using GuitarShop.ConcreteComponent;
using GuitarShop.ConcreteDecorator;
using GuitarShop.Iterator;

namespace GuitarShop.MyMusicalInstruments
{
    public class MyGuitars : IGuitarsOwner
    {
        private static readonly MyGuitars _instance = new();
        private Guitar[] _myGuitars;
        public static MyGuitars Instance
        {
            get
            {
                return _instance;
            }
        }

        public MyGuitars()
        {
            _myGuitars = new Guitar[] { new Tuner(new PickGuard(new ElectricGuitar())), new Tuner(new PiezoPickup(new PickGuard(new TwelveStringsGuitar()))) };
        }

        public Guitar[] GetGuitars => _myGuitars;

        public IIterator CreateIterator()
        {
            return new MyGuitarsIterator(_myGuitars);
        }
    }
} 