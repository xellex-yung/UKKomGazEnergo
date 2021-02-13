using System;
using System.Collections.Generic;
using System.Text;

namespace UKKomGazEnergo
{
    public class ProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product[] GetAllByQuery(string query)
        {
            if (IsCountry(query))
                return productRepository.GetAllByCountry(query);

            return productRepository.GetAllByTitleOrManufacturer(query);

        }
    }
}
