namespace PricerSupermarket.Tests
{
    /// <summary>
    /// Define the Pricer Interface
    /// </summary>
    public interface IPricer
    {
        /// <summary>
        /// Gets the total price.
        /// </summary>
        decimal GetTotalPrice(List<Product> products);
    }
}