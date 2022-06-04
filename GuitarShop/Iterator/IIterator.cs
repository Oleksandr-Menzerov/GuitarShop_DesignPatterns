using GuitarShop.Component;

namespace GuitarShop.Iterator
{
    public interface IIterator
    {
        void First();
        Guitar Next();
        bool IsDone();
        Guitar CurrentItem();
        int Count();
        Guitar GetElementAt(int index);

        public string GetGuitarsDescription()
        {
            if (Count() > 0)
            {
                string result = string.Empty;
                for (int i = 0; i < Count(); i++)
                {
                    var guitar = GetElementAt(i);
                    result += $"{guitar.GetDescription()} {guitar.GetGuitarPrice():C2}\n";
                }
                return result;
            }
            else
            {
                return "There are no guitars yet.";
            }
        }
    }
}
