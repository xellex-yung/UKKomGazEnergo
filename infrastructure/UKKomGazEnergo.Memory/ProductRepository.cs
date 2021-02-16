using System.Linq;

namespace UKKomGazEnergo.Memory
{
    public class ProductRepository : IProductRepository
    {
        private readonly Product[] products = new[]
        {
            new Product(1,"country1","Manufacturer1","OneSomeThing","desc1",0.17m),
            new Product(2,"country2","Manufacturer2","TwoSomeThing","desc2",0.10m),
            new Product(3,"country3","Manufacturer3","ThreeSomeThing","desc1",0.4m),
        };
     
        public Product[] GetAllByTitleOrManufacturerOrCountry(string titlePart)
        {
            return products.Where(product => product.Title.Contains(titlePart) 
                                           || product.Manufacturer.Contains(titlePart)
                                           || product.Country.Contains(titlePart))
                            .ToArray();
                                                       
        }    
    }
}
