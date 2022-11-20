using PricerSupermarket.Console.EnumHelpers;
using PricerSupermarket.Console.Models;

namespace PricerSupermarket.Console.Pricer
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
        /// <exception cref="System.NotImplementedException"></exception>
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
