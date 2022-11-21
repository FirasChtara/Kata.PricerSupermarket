using PricerSupermarket.Console.Models;

namespace PricerSupermarket.Console.Pricer.Abstraction;

/// <summary>
/// Define the Cart Item Pricer Interface
/// </summary>
public interface ICartItemPricer
{
    /// <summary>
    /// calculate price of specified cart item.
    /// </summary>
    /// <param name="cartItem">The cart item.</param>
    /// <returns></returns>
    decimal Price(CartItem cartItem);
}