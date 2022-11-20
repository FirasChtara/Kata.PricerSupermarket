using PricerSupermarket.Console.EnumHelpers;
using PricerSupermarket.Console.Models;
using PricerSupermarket.Console.Pricer.Implementation;

namespace PricerSupermarket.Tests
{
    public class TwoPoundForOneDollarTests
    {

        [Theory]
        [InlineData(1600, Unit.Gram, 2.83)]
        [InlineData(1.6, Unit.Kg, 2.83)]
        [InlineData(56.4383, Unit.Ounce, 2.83)]
        [InlineData(3.5274, Unit.Pound, 2.83)]
        [InlineData(2, Unit.Pound, 1)]
        [InlineData(4, Unit.Pound, 2)]
        [InlineData(3, Unit.Pound, 2.2)]
        public void should_apply_promotion_twoPoundForOneDollar_with_eligible_product(double quantity, Unit unitItem, decimal expectedPrice)
        {
            // Arrange
            var cartItem = new CartItem()
            {
                Product = TestHelpers.InitProductsList().FirstOrDefault(),
                Quantity = quantity,
                Promotion = Promotion.TwoPoundsForOneDollar,
                Unit = unitItem
            };

            // Act
            var actual = new TwoPoundForOneDollarItemPricer().Price(cartItem);

            // Assert
            Assert.Equal(expectedPrice, actual);
        }
    }
}
