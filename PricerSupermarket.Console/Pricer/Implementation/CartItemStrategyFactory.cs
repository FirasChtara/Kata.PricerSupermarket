using PricerSupermarket.Console.EnumHelpers;
using PricerSupermarket.Console.Models;
using PricerSupermarket.Console.Pricer.Abstraction;

namespace PricerSupermarket.Console.Pricer.Implementation
{
    /// <summary>
    ///  Define the Cart Item Strategy Factory
    /// </summary>
    public class CartItemStrategyFactory : ICartItemStrategyFactory
    {
        /// <summary>
        /// Creates the strategy.
        /// </summary>
        /// <param name="cartItem">The cart item.</param>
        /// <returns></returns>
        public ICartItemPricer CreateStrategy(CartItem cartItem)
        {
            switch (cartItem.Promotion)
            {
                case Promotion.WithoutPromotion:
                    return new StandardItemPricer();
                case Promotion.ByTwoGetOneFree:
                    throw new NotImplementedException();
                case Promotion.ThreeForOneDollar:
                    return new ThreeForOneDollarItemPricer();
                case Promotion.TwoPoundsForOneDollar:
                    throw new NotImplementedException();
                default:
                    return new StandardItemPricer();
            }
        }
    }
}
