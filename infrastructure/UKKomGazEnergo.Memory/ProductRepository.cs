using System.Linq;

namespace UKKomGazEnergo.Memory
{
    public class ProductRepository : IProductRepository
    {
        private readonly Product[] products = new[]
        {
            new Product(1,"OneSomeThing"),
            new Product(2,"TwoSomeThing"),
            new Product(3,"ThreeSomeThing"),
        };
        public Product[] GetAllByTitle(string titlePart)
        {
            return products.Where(products => products.Title.Contains(titlePart)).ToArray();
        }
    }
}
