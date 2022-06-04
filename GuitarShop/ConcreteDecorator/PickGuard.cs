using GuitarShop.Component;
using GuitarShop.Decorator;

namespace GuitarShop.ConcreteDecorator
{
    public class PickGuard : GuitarDecorator
    {
        public PickGuard(Guitar guitar)
            : base(guitar)
        {
            Description = "PickGuard";
        }

        public override string GetDescription() => $"{_guitar.GetDescription()}, {Description}";

        public override double GetGuitarPrice() => _guitar.GetGuitarPrice() + 50;
    }
}