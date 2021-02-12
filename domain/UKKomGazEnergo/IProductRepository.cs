
namespace UKKomGazEnergo
{
    public interface IProductRepository
    {
        Product[] GetAllByTitle(string titlePart);
    }
}
