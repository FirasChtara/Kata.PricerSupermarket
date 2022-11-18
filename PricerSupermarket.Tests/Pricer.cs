namespace PricerSupermarket.Tests
{
    /// <summary>
    ///  Define the Pricer Class
    /// </summary>
    /// <seealso cref="PricerSupermarket.Tests.IPricer" />
    public class Pricer : IPricer
    {
        /// <summary>
        /// Gets the total price.
        /// </summary>
        /// <param name="products"></param>
        public decimal GetTotalPrice(List<Product> products)
        {
            decimal total = 0;
            products.ForEach(p =>
            {
                total += p.Price;
            });
            return total;
        }
    }
}