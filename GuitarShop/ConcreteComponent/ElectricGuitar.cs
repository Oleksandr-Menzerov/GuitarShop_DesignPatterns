using GuitarShop.Component;

namespace GuitarShop.ConcreteComponent
{
    internal class ElectricGuitar : Guitar
    {
        private readonly int stringsNumber = 6;
        public ElectricGuitar(int fretsNumber = 22, int stringsNumber = 6, string pickups = "2 humbackers")
        {
            Description = $"Electric Guitar with {pickups}";
            SetFretsNumber(fretsNumber, 19, 28);
            if (stringsNumber > 5 && stringsNumber < 33)
            {
                this.stringsNumber = stringsNumber;
            }
            else
            {
                throw new Exception($"Invalid strings number. Expected: from 6 (standard) to 32 (stick). Actual: {stringsNumber}");
            }
        }

        public override double GetGuitarPrice() => 1000.00;
        public override string GetDescription() => Description;
        public override int GetStringsNumber() => stringsNumber;
        public override int GetFretsNumber() => FretsNumber;
    }
}
