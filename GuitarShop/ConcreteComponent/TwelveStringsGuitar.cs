using GuitarShop.Component;

namespace GuitarShop.ConcreteComponent
{
    // ConcreteComponent
    public class TwelveStringsGuitar : Guitar
    {
        public TwelveStringsGuitar()
        {
            Description = "Twelve Strings Guitar";
            FretsNumber = 22;
        }

        public TwelveStringsGuitar(int fretsNumber)
        {
            Description = "Twelve Strings Guitar";
            SetFretsNumber(fretsNumber, 20, 24);
        }

        public override double GetGuitarPrice() => 700.00;
        public override string GetDescription() => Description;
        public override int GetStringsNumber() => 12;
        public override int GetFretsNumber() => FretsNumber;
    }
}