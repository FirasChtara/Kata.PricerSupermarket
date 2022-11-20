using PricerSupermarket.Console.Models;
using PricerSupermarket.Console.Pricer.Abstraction;

namespace PricerSupermarket.Console.Pricer.Implementation
{
    public class BuyTwoGetOneFreeItemPricer : ICartItemPricer
    {
        public decimal Price(CartItem cartItem)
        {
            if (cartItem.Unit != EnumHelpers.Unit.Piece)
                throw new InvalidOperationException("Product Not eligible for promotion!");

            decimal price;

            if (cartItem.Quantity % 2 != 0)
                price = cartItem.Product.Price * (decimal)(cartItem.Quantity  - (int)(cartItem.Quantity / 3));
            else
            {
                price = cartItem.Product.Price * (decimal)cartItem.Quantity;
                cartItem.Quantity += cartItem.Quantity / 2;
            }
            return decimal.Round(price, 2, MidpointRounding.AwayFromZero);
        }
    }
}
