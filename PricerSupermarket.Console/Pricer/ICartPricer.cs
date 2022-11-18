using PricerSupermarket.Console.Models;

namespace PricerSupermarket.Console
{
    /// <summary>
    /// Define the Cart Pricer Interface
    /// </summary>
    public interface ICartPricer
    {
        /// <summary>
        /// Gets the total price.
        /// </summary>
        /// <param name="cart">The cart.</param>
        decimal GetTotalPrice(Cart cart);
    }
}