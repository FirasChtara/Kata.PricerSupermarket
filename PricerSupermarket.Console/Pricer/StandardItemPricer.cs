using PricerSupermarket.Console.Models;

namespace PricerSupermarket.Console.Pricer
{
    /// <summary>
    ///  Define the Standard Item Pricer
    /// </summary>
    public class StandardItemPricer : ICartItemPricer
    {
        /// <summary>
        /// Prices the specified cart item.
        /// </summary>
        /// <param name="cartItem">The cart item.</param>
        public decimal Price(CartItem cartItem)
        {
            if (cartItem.Product == null)
                throw new ArgumentNullException(nameof(cartItem.Product));

            return cartItem.Quantity * cartItem.Product.Price;
        }
    }
}
