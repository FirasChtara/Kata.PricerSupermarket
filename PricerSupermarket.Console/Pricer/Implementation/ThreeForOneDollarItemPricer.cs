using PricerSupermarket.Console.Models;
using PricerSupermarket.Console.Pricer.Abstraction;

namespace PricerSupermarket.Console.Pricer.Implementation;

/// <summary>
/// Define the Three For One Dollar Item Pricer
/// </summary>
public class ThreeForOneDollarItemPricer : ICartItemPricer
{
    /// <summary>
    /// Caculate price for the specific cart item
    /// </summary>
    /// <param name="cartItem">The cart item.</param>
    /// <returns></returns>
    public decimal Price(CartItem cartItem)
    {
        if (cartItem.Unit != EnumHelpers.Unit.Piece)
            throw new InvalidOperationException("Product Not eligible for promotion!");

        decimal price = (int)(cartItem.Quantity / 3);

        for (int i = 0; i < cartItem.Quantity % 3; i++)
        {
            price += cartItem.Product.Price;
        }

        return decimal.Round(price, 2, MidpointRounding.AwayFromZero);
    }
}