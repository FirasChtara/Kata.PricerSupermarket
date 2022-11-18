using PricerSupermarket.Console.Models;
using PricerSupermarket.Console.Pricer;

namespace PricerSupermarket.Tests
{
    public class PriceTests
    {
        [Fact]
        public void should_calcul_total_price_of_all_items()
        {
            var productsList = InitProductsList();
            var cart = InitCart(productsList);

            // Act
            var totalPrice = new Pricer().GetTotalPrice(cart);

            // Assert
            Assert.Equal(820, totalPrice);
        }

        #region Tests Helpers        

        /// <summary>
        /// Initializes the cart.
        /// </summary>
        /// <param name="productsList">The products list.</param>
        private static Cart InitCart(List<Product> productsList)
        {
            return new Cart
            {
                Id = Guid.NewGuid(),
                CartItems = new List<CartItem>
                {
                  new CartItem
                  {
                      Quantity= 2,
                      Product = productsList[0]

                  },
                   new CartItem
                  {
                      Quantity= 4,
                      Product = productsList[1]

                  }
                }
            };
        }

        /// <summary>
        /// Initializes the products list.
        /// </summary>
        private static List<Product> InitProductsList()
        {
            // Arrange
            return new List<Product>()
             {
                 new Product
                 {
                    Id = Guid.NewGuid(),
                    Name= "Product Name 1",
                    Price = 120,
                 },
                    new Product
                 {
                    Id = Guid.NewGuid(),
                    Name= "Product Name 2",
                    Price = 145,
                 }
             };
        }
        #endregion
    }
}