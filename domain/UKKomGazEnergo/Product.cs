
namespace UKKomGazEnergo
{
    public class Product
    {
 
        public int Id { get; set; }
        public string Title { get; }
        public string  Country { get; }
        public string Manufacturer { get; }
        public Product(int id, string title, string country, string manufacturer)
        {
            Id = id;
            Title = title;
            Country = country;
            Manufacturer = manufacturer;
        }
        internal static bool IsCountry(string)
        {
            return false;
        }



    }
}
