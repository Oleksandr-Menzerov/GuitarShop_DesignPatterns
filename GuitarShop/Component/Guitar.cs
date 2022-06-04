namespace GuitarShop.Component
{
    // Component
    public abstract class Guitar
    {
        public string Description { get; set; }
        public int FretsNumber;
        public abstract string GetDescription();
        public abstract double GetGuitarPrice();
        public abstract int GetStringsNumber();
        public abstract int GetFretsNumber();
        public void SetFretsNumber(int num, int minNum, int maxNum)
        {
            if (num >= minNum && num <= maxNum)
            {
                FretsNumber = num;
            }
            else
            {
                throw new Exception($"Invalid frets number. Expected: from {minNum} to {maxNum}. Actual: {num}");
            }
        }
    }
}