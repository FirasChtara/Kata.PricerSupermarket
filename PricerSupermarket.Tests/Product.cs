namespace PricerSupermarket.Tests
{
    /// <summary>
    ///  Define the Product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
       
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public decimal Price { get; set; }
    }
}