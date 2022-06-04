using GuitarShop.Component;

namespace GuitarShop.ConcreteComponent
{
    // ConcreteComponent
    public class Ukulele : Guitar
    {
        public Ukulele()
        {
            Description = "Ukulele";
            FretsNumber = 15;
        }

        public Ukulele(int fretsNumber)
        {
            Description = "Ukulele";
            SetFretsNumber(fretsNumber, 12, 20);
        }

        public override double GetGuitarPrice() => 300.00;
        public override string GetDescription() => Description;
        public override int GetStringsNumber() => 4;
        public override int GetFretsNumber() => FretsNumber;
    }
}