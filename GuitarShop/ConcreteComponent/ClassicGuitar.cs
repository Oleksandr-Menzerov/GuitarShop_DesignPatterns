using GuitarShop.Component;

namespace GuitarShop.ConcreteComponent
{
    // ConcreteComponent
    public class ClassicGuitar : Guitar
    {
        public ClassicGuitar()
        {
            Description = "Classic Guitar";
            FretsNumber = 20;
        }

        public ClassicGuitar(int fretsNumber)
        {
            Description = "Classic Guitar";
            SetFretsNumber(fretsNumber, 18, 24);
        }

        public override double GetGuitarPrice() => 500.00;
        public override string GetDescription() => Description;
        public override int GetStringsNumber() => 6;
        public override int GetFretsNumber() => FretsNumber;
    }
}