using System.Linq;

namespace UKKomGazEnergo.Memory
{
    public class ProductRepository : IProductRepository
    {
        private readonly Product[] products = new[]
        {
            new Product(1,"country1","Manufacturer3","OneSomeThing"),
            new Product(2,"country2","Manufacturer8","TwoSomeThing"),
            new Product(3,"country3","Manufacturer7","ThreeSomeThing"),
        };

        public Product[] GetAllByCountry(string titlePart)
        {
            throw new System.NotImplementedException();
        }

        public Product[] GetAllByTitleOrManufacturer(string titlePart)
        {
            return products.Where(products => products.Title.Contains(titlePart)).ToArray();
        }
    }
}
