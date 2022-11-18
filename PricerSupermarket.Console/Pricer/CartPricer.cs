using PricerSupermarket.Console.Models;

namespace PricerSupermarket.Console.Pricer
{
    /// <summary>
    ///  Define the Cart Pricer Class
    /// </summary>
    /// <seealso cref="ICartPricer" />
    public class CartPricer : ICartPricer
    {
        ICartItemPricer _cartItemPricer;
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