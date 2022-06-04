using GuitarShop.Component;
using GuitarShop.Decorator;

namespace GuitarShop.ConcreteDecorator
{
    public class PiezoPickup : GuitarDecorator
    {
        public PiezoPickup(Guitar guitar) : base(guitar)
        {
            Description = "Piezoelectric Pickup";
        }

        public override string GetDescription() =>
                                $"{_guitar.GetDescription()}, {Description}";


        public override double GetGuitarPrice() => _guitar.GetGuitarPrice() + 100;
    }
}