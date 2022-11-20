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
        /// The cart item pricer
        /// </summary>
        ICartItemPricer _cartItemPricer;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartPricer"/> class.
        /// </summary>
        /// <param name="cartItemPricer">The cart item pricer.</param>
        public CartPricer(ICartItemPricer cartItemPricer)
        {
            _cartItemPricer = cartItemPricer ?? throw new ArgumentNullException(nameof(cartItemPricer));
        }

        /// <inheritdoc />
        public decimal GetTotalPrice(Cart cart)
        {
            decimal total = 0;

            cart.CartItems.ForEach(p =>
            {
                total += _cartItemPricer.Price(p);
            });
            return total;
        }
    }
}