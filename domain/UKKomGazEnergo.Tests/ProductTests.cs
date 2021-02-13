using System;
using Xunit;

namespace UKKomGazEnergo.Tests
{
    public class ProductTests
    {
        [Fact]
        public void IsCountry_WithNull_ReturnFalse()
        {
            bool actual = Product.IsCountry(null);
            Assert.False(actual)
        }
    }
}
