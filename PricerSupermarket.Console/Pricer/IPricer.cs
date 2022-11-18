using PricerSupermarket.Console.Models;

namespace PricerSupermarket.Console
{
    /// <summary>
    /// Define the Pricer Interface
    /// </summary>
    public interface IPricer
    {
        /// <summary>
        /// Gets the total price.
        /// </summary>
        /// <param name="cart">The cart.</param>
        decimal GetTotalPrice(Cart cart);
    }
}