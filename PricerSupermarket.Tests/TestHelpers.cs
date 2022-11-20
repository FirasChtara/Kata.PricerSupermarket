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
                      Product = productsList[0],
                      Unit = Unit.Piece
                  },
                   new CartItem
                  {
                      Quantity= 4,
                      Product = productsList[1],
                      Unit = Unit.Piece
                  },
                     new CartItem
                  {
                      Quantity= 7,
                      Product = productsList[0],
                      Promotion=Promotion.ThreeForOneDollar,
                      Unit = Unit.Piece
                  },
                     new CartItem
                  {
                      Quantity= 1600,
                      Product = productsList[0],
                      Promotion=Promotion.TwoPoundsForOneDollar,
                      Unit = Unit.Gram
                  },
                     new CartItem
                  {
                      Quantity= 7,
                      Product = productsList[0],
                      Promotion=Promotion.BuyTwoGetOneFree,
                      Unit = Unit.Piece
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
