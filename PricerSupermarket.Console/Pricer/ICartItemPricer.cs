using PricerSupermarket.Console.Models;

namespace PricerSupermarket.Console.Pricer
{
    /// <summary>
    /// Define the Cart Item Pricer Interface
    /// </summary>
    public interface ICartItemPricer
    {
        /// <summary>
        /// Prices the specified cart item.
        /// </summary>
        /// <param name="cartItem">The cart item.</param>
        /// <returns></returns>
        decimal Price(CartItem cartItem);
    }
}