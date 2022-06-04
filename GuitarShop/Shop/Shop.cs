using GuitarShop.Component;
using GuitarShop.Iterator;

namespace GuitarShop
{
    public class Shop : IGuitarsOwner
    {
        private static readonly Shop _instance = new();

        public static Shop Instance
        {
            get
            {
                return _instance;
            }
        }

        public Shop()
        {

        }
        private int Id { get; set; } = 123;
        private string ShopName { get; set; } = "World Guitars";
        private string ShopAddress { get; set; } = "Musicians street, 1";
        private string OpeningTime { get; set; } = "8:00";
        private string ClosingTime { get; set; } = "20:00";
        private readonly List<Guitar> _shopGuitars = new() ;
        public string GetShopName() => ShopName;
        public string GetShopAddress() => ShopAddress;
        public string GetShopWorkingHours() => $"Shop works from {OpeningTime} to {ClosingTime}";
        public void AddGuitar(Guitar guitar)
        {
            _shopGuitars.Add(guitar);
        }
        public void RemoveGuitar(Guitar guitar)
        {
            _shopGuitars.Remove(guitar);
        }
        public List<Guitar> GetGuitars => _shopGuitars;

        public IIterator CreateIterator()
        {
            return new ShopGuitarsIterator(_shopGuitars);
        }
    }
}