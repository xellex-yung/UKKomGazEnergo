
namespace UKKomGazEnergo
{
    public interface IProductRepository
    {      
        Product[] GetAllByTitleOrManufacturerOrCountry(string titlePart);
    }
}
