using PricerSupermarket.Console.Pricer.Implementation;

namespace PricerSupermarket.Tests
{
    public class CartPricerTests
    {
        [Fact]
        public void should_calcul_total_price_of_all_items()
        {
            // Arrange
            var productsList = TestHelpers.InitProductsList();
            var cart = TestHelpers.InitCart(productsList);

            // Act
            var totalPrice = new CartPricer(new CartItemStrategyFactory()).GetTotalPrice(cart);

            // Assert
            Assert.Equal(11.4m, totalPrice);
        }
    }
}