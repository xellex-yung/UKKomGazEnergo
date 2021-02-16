using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UKKomGazEnergo.Tests
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetAllByQuery_WithCountry_Calls_GetAllByCountry()
        {
            var productRepository = new Mock<IProductRepository>();
            productRepository.Setup(x => x.GetAllByTitleOrManufacturerOrCountry(It.IsAny<string>()))
                             .Returns(new[] { new Product(1, "", "", "") });
            productRepository.Setup(x => x.GetAllByTitleOrManufacturerOrCountry(It.IsAny<string>()))
                            .Returns(new[] { new Product(2, "", "", "") });
            var productService = new ProductService(productRepository.Object);

            var actual = productService.GetAllByQuery("asdad");
            Assert.Collection(actual, product => Assert.Equal(1, product.Id));
        }

    }
}
