using PricerSupermarket.Console.Models;

namespace PricerSupermarket.Console.Pricer
{
    /// <summary>
    ///  Define the Pricer Class
    /// </summary>
    /// <seealso cref="IPricer" />
    public class Pricer : IPricer
    {
        /// <inheritdoc />
        public decimal GetTotalPrice(Cart cart)
        {
            decimal total = 0;
            cart.CartItems.ForEach(p =>
            {
                total += p.Quantity * p.Product.Price;
            });
            return total;
        }
    }
}