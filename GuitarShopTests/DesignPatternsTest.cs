using GuitarShop.Component;
using GuitarShop.ConcreteComponent;
using GuitarShop.ConcreteDecorator;
using NUnit.Framework;

namespace GuitarShop
{
    public class SingletonTests
    {
        [Test]
        public void IsShopASingleton()
        {
            Assert.AreSame(Shop.Instance, Shop.Instance);
        }

        [Test]
        public void IsMyGuitarsSingleton()
        {
            Assert.AreSame(MyMusicalInstruments.MyGuitars.Instance, MyMusicalInstruments.MyGuitars.Instance);
        }
    }

    public class DecoratorTests
    {
        [Test]
        public void IsDescriptionAdded()
        {
            ClassicGuitar guitar1 = new();
            Tuner guitar2 = new(guitar1);
            var description = guitar2.GetDescription();
            Assert.IsTrue(description.Contains("Tuner"), $"Actual description {description} not contain 'Tuner'");
        }

        [Test]
        public void IsPriceAdded()
        {
            TwelveStringsGuitar guitar1 = new();
            PiezoPickup guitar2 = new(guitar1);

            var expectedPrice = guitar1.GetGuitarPrice() + 100;
            var actualPrice = guitar2.GetGuitarPrice();

            Assert.AreEqual(expectedPrice, actualPrice, $"Expected price is {expectedPrice:C2} but actual is {actualPrice:C2}");
        }
    }

    public class IteratorTests
    {
        [Test]
        public void IsElementAtFoundFromArray()
        {
            var elementOfArray = MyMusicalInstruments.MyGuitars.Instance.GetGuitars[1];
            var elementAt = MyMusicalInstruments.MyGuitars.Instance.CreateIterator().GetElementAt(1);

            Assert.AreEqual(elementOfArray, elementAt, $"Elements are not equal");
        }

        [Test]
        public void IsElementAtFoundFromList()
        {
            Guitar twelveStr = new TwelveStringsGuitar(24);
            twelveStr = new PickGuard(twelveStr);
            twelveStr = new Tuner(twelveStr);
            twelveStr = new PiezoPickup(twelveStr);

            Guitar ukulele = new Ukulele(18);
            ukulele = new PickGuard(ukulele);

            Guitar classic = new ClassicGuitar(22);
            classic = new PickGuard(classic);
            classic = new Tuner(classic);

            Shop.Instance.AddGuitar(twelveStr);
            Shop.Instance.AddGuitar(twelveStr);
            Shop.Instance.AddGuitar(ukulele);
            Shop.Instance.AddGuitar(classic);
            Shop.Instance.AddGuitar(classic);
            Shop.Instance.AddGuitar(classic);

            var elementOfList = Shop.Instance.GetGuitars.ToArray()[3];
            var elementAt = Shop.Instance.CreateIterator().GetElementAt(3);

            Assert.AreEqual(elementOfList, elementAt, $"Elements are not equal");
        }
    }
}