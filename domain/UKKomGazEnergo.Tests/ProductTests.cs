using System;
using Xunit;

namespace UKKomGazEnergo.Tests
{
    public class ProductTests
    {
        [Fact]
        public void IsCountry_WithNull_ReturnFalse()
        {
            bool actual = Product.IsCountry("IsBn 123-456-789 0");
            Assert.False(actual);
        }
        [Fact]
        public void IsCountry_With_Space()
        {
            bool actual = Product.IsCountry("");
            Assert.True(actual);
        }
    }
}
