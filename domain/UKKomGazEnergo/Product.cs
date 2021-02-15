
namespace UKKomGazEnergo
{
    public class Product
    { 
        public int Id { get; set; }
        public string Title { get; }
        public string  Country { get; }
        public string Manufacturer { get; }
        public Product(int id, string country, string manufacturer, string title)
        {
            Id = id;         
            Country = country;
            Manufacturer = manufacturer;
            Title = title;
        }
        internal static bool IsCountry(string query)
        {
            return string.IsNullOrEmpty(query);
        }



    }
}
