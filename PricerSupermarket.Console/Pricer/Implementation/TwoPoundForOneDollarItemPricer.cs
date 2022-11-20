using PricerSupermarket.Console.Models;
using PricerSupermarket.Console.Pricer.Abstraction;

namespace PricerSupermarket.Console.Pricer.Implementation
{
    public class TwoPoundForOneDollarItemPricer : ICartItemPricer
    {
        public decimal Price(CartItem cartItem)
        {
            if (cartItem.Unit == EnumHelpers.Unit.Piece)
                throw new InvalidOperationException("Product Not eligible for promotion!");

            cartItem.Quantity = Helpers.Helpers.ConvertToPound(cartItem.Quantity, cartItem.Unit);

            decimal price = (int)(cartItem.Quantity / 2);
            var restQuantity = (decimal)cartItem.Quantity % 2;
            var restQuantityPrice = cartItem.Product.Price * restQuantity;

            price += restQuantityPrice;

            return decimal.Round(price, 2, MidpointRounding.AwayFromZero);
        }
    }
}
