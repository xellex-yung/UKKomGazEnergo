
namespace UKKomGazEnergo
{
    public interface IProductRepository
    {
        Product[] GetAllByCountry(string titlePart);
        Product[] GetAllByTitleOrManufacturer(string titlePart);
    }
}
