using GuitarShop.Component;

namespace GuitarShop.Decorator
{
    // Decorator
    public class GuitarDecorator : Guitar
    {
        protected Guitar _guitar;
        public GuitarDecorator(Guitar guitar)
        {
            _guitar = guitar;
        }

        public override double GetGuitarPrice() => _guitar.GetGuitarPrice();

        public override string GetDescription() => _guitar.GetDescription();

        public override int GetStringsNumber() => _guitar.GetStringsNumber();

        public override int GetFretsNumber() => _guitar.GetFretsNumber();
    }
}