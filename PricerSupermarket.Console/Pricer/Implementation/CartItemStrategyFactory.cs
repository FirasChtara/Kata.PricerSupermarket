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
                case Promotion.BuyTwoGetOneFree:
                    return new BuyTwoGetOneFreeItemPricer();
                case Promotion.ThreeForOneDollar:
                    return new ThreeForOneDollarItemPricer();
                case Promotion.TwoPoundsForOneDollar:
                    return new TwoPoundForOneDollarItemPricer();
                default:
                    return new StandardItemPricer();
            }
        }
    }
}
