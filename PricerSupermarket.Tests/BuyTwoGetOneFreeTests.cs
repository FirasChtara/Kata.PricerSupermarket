using PricerSupermarket.Console.EnumHelpers;
using PricerSupermarket.Console.Models;
using PricerSupermarket.Console.Pricer.Implementation;

namespace PricerSupermarket.Tests
{
    public class BuyTwoGetOneFreeTests
    {
        [Theory]
        [InlineData(2, 2.4,3)]
        [InlineData(3, 2.4,3)]
        [InlineData(7, 6,7)]
        [InlineData(8, 9.6,12)]
        [InlineData(9,7.2 ,9)]
        public void should_apply_promotion_BuyTwoGetOneFree_with_eligible_product(int quantity, decimal expectedPrice,int expectedQuantity)
        {
            // Arrange
            var cartItem = new CartItem()
            {
                Product = TestHelpers.InitProductsList().FirstOrDefault(),
                Quantity = quantity,
                Promotion = Promotion.BuyTwoGetOneFree,
                Unit = Unit.Piece
            };

            // Act
            var actual = new BuyTwoGetOneFreeItemPricer().Price(cartItem);

            // Assert
            Assert.Equal(expectedPrice, actual);
            Assert.Equal(expectedQuantity, cartItem.Quantity);
        }
    }
}
