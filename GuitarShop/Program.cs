using GuitarShop.Component;
using GuitarShop.ConcreteComponent;
using GuitarShop.ConcreteDecorator;

namespace GuitarShop
{
    class Program
    {
        static void Main()
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

            Console.WriteLine(twelveStr.GetDescription());
            Console.WriteLine($"{twelveStr.GetGuitarPrice():C2}");
            Console.WriteLine(ukulele.GetDescription());
            Console.WriteLine($"{ukulele.GetGuitarPrice():C2}");
            Console.WriteLine(classic.GetDescription());
            Console.WriteLine($"{classic.GetGuitarPrice():C2}");

            Shop.Instance.AddGuitar(twelveStr);
            Shop.Instance.AddGuitar(twelveStr);
            Shop.Instance.AddGuitar(ukulele);
            Shop.Instance.AddGuitar(classic);
            Shop.Instance.AddGuitar(classic);
            Shop.Instance.AddGuitar(classic);

            Console.WriteLine(Shop.Instance.GetShopName());
            Console.WriteLine(Shop.Instance.GetShopWorkingHours());
            Console.WriteLine(Shop.Instance.CreateIterator().GetGuitarsDescription());
            Console.WriteLine(MyMusicalInstruments.MyGuitars.Instance.CreateIterator().GetGuitarsDescription());

            Console.ReadKey();
        }
    }
}