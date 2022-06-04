using GuitarShop.Component;
using GuitarShop.Decorator;

namespace GuitarShop.ConcreteDecorator
{
    public class Tuner : GuitarDecorator
    {
        public Tuner(Guitar guitar) : base(guitar)
        {
            Description = "Tuner";
        }

        public override string GetDescription() => $"{_guitar.GetDescription()}, {Description}";

        public override double GetGuitarPrice() => _guitar.GetGuitarPrice() + 50;
    }
}