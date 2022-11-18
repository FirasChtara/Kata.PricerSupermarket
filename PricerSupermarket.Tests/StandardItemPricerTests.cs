using PricerSupermarket.Console.Models;
using PricerSupermarket.Console.Pricer;

namespace PricerSupermarket.Tests
{
    public class StandardItemPricerTests
    {
        [Fact]
        public void should_calcul_price_of_cart_item()
        {
            // Arrange
            var cartItem = new CartItem()
            {
                Product = TestHelpers.InitProductsList().FirstOrDefault(),
                Quantity = 2
            };

            // Act
            var actual = new StandardItemPricer().Price(cartItem);

            // Assert
            Assert.Equal(240, actual);
        }

        [Fact]
        public void should_throw_exception_when_product_in_cartItem_is_null()
        {
            // Arrange
            var cartItem = new CartItem()
            {
                Product = null,
                Quantity = 2
            };

            // Act + Assert
            var ex = Assert.ThrowsAny<Exception>(() => new StandardItemPricer().Price(cartItem));


        }
    }
}
