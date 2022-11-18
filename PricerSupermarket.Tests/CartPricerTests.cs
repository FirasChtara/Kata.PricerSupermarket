using PricerSupermarket.Console.Pricer;

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
            var totalPrice = new CartPricer(new StandardItemPricer()).GetTotalPrice(cart);

            // Assert
            Assert.Equal(820, totalPrice);
        }

        [Fact]
        public void should_throw_argument_exception_if_itemPricer_is_null()
        {
            Assert.ThrowsAny<ArgumentNullException>(() => new CartPricer(null));
        }
    }
}