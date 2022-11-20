using PricerSupermarket.Console.EnumHelpers;
using PricerSupermarket.Console.Models;
using PricerSupermarket.Console.Pricer;

namespace PricerSupermarket.Tests
{
    public class ThreeForOneDollarTests
    {

        [Theory]
        [InlineData(3, 1)]
        [InlineData(6, 2.0)]
        [InlineData(9, 3.0)]
        [InlineData(1, 1.2)]
        [InlineData(5, 3.4)]
        [InlineData(7, 3.2)]
        public void should_apply_promotion_threeForOneDollar_with_illegible_product(int quantity, decimal expectedPrice)
        {
            // Arrange
            var cartItem = new CartItem()
            {
                Product = TestHelpers.InitProductsList().FirstOrDefault(),
                Quantity = quantity,
                Promotion = Promotion.ThreeForOneDollar
            };

            // Act
            var actual = new ThreeForOneDollarItemPricer().Price(cartItem);

            // Assert
            Assert.Equal(expectedPrice, actual);
        }
    }
}
