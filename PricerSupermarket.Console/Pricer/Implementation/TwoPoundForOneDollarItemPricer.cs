using PricerSupermarket.Console.Helpers;
using PricerSupermarket.Console.Models;
using PricerSupermarket.Console.Pricer.Abstraction;

namespace PricerSupermarket.Console.Pricer.Implementation;

/// <summary>
///  Define the Two Pound For One Dollar Item Pricer
/// </summary>
public class TwoPoundForOneDollarItemPricer : ICartItemPricer
{
    /// <summary>
    /// Caculate price for the specific cart item
    /// </summary>
    /// <param name="cartItem">The cart item.</param>
    /// <returns></returns>
    public decimal Price(CartItem cartItem)
    {
        if (cartItem.Unit == EnumHelpers.Unit.Piece)
            throw new InvalidOperationException("Product Not eligible for promotion!");

        cartItem.Quantity = cartItem.Quantity.ToPound(cartItem.Unit);

        decimal price = (int)(cartItem.Quantity / 2);
        var restQuantity = (decimal)cartItem.Quantity % 2;
        var restQuantityPrice = cartItem.Product.Price * restQuantity;

        price += restQuantityPrice;

        return decimal.Round(price, 2, MidpointRounding.AwayFromZero);
    }
}
