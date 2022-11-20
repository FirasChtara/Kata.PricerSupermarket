using PricerSupermarket.Console.EnumHelpers;
using PricerSupermarket.Console.Models;

namespace PricerSupermarket.Tests
{
    internal static class TestHelpers
    {
        /// <summary>
        /// Initializes the cart.
        /// </summary>
        /// <param name="productsList">The products list.</param>
        internal static Cart InitCart(List<Product> productsList)
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

                  },
                     new CartItem
                  {
                      Quantity= 7,
                      Product = productsList[0],
                      Promotion=Promotion.ThreeForOneDollar

                  }
                }
            };
        }

        /// <summary>
        /// Initializes the products list.
        /// </summary>
        internal static List<Product> InitProductsList()
        {
            // Arrange
            return new List<Product>()
             {
                 new Product
                 {
                    Id = Guid.NewGuid(),
                    Name= "Product Name 1",
                    Price = 1.2m,
                 },
                    new Product
                 {
                    Id = Guid.NewGuid(),
                    Name= "Product Name 2",
                    Price = 1.45m,
                 }
             };
        }
    }
}
