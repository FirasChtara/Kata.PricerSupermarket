using PricerSupermarket.Console.Models;

namespace PricerSupermarket.Console.Pricer
{
    /// <summary>
    ///  Define the Cart Pricer Class
    /// </summary>
    /// <seealso cref="ICartPricer" />
    public class CartPricer : ICartPricer
    {
        /// <summary>
        /// The cart item strategy factory
        /// </summary>
        private readonly ICartItemStrategyFactory _cartItemStrategyFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartPricer"/> class.
        /// </summary>
        /// <param name="cartItemStrategyFactory">The cart item strategy factory.</param>
        public CartPricer(ICartItemStrategyFactory cartItemStrategyFactory)
        {
            _cartItemStrategyFactory = cartItemStrategyFactory;
        }

        /// <inheritdoc />
        public decimal GetTotalPrice(Cart cart)
        {
            decimal total = 0;

            cart.CartItems.ForEach(item =>
            {
                ICartItemPricer pricer = _cartItemStrategyFactory.CreateStrategy(item);
                total += pricer.Price(item);
            });

            return total;
        }
    }
}