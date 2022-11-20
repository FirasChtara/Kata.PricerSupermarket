using PricerSupermarket.Console.Models;

namespace PricerSupermarket.Console.Pricer
{
    /// <summary>
    ///  Define the Cart Item Strategy Factory interface
    /// </summary>
    public interface ICartItemStrategyFactory
    {
        /// <summary>
        /// Creates the strategy.
        /// </summary>
        /// <param name="cartItem">The cart item.</param>
        /// <returns></returns>
        ICartItemPricer CreateStrategy(CartItem cartItem);
    }
}