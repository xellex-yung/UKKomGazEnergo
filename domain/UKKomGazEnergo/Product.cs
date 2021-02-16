
namespace UKKomGazEnergo
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; }
        public string Country { get; }
        public string Manufacturer { get; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public Product(int id, string title, string country, string manufacturer, string description, decimal price)
        {
            Id = id;
            Country = country;
            Manufacturer = manufacturer;
            Title = title;   
            Description = description;
            Price = price;
        }

        internal static bool IsCountry(string query)
        {
            return string.IsNullOrEmpty(query);
        }
    }
}
