
namespace UKKomGazEnergo
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; }
        public Product(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
