namespace PricerSupermarket.Console.Models
{
    /// <summary>
    ///  Define the Cart Item class
    /// </summary>
    public class CartItem
    {
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        public Product Product { get; set; }
    }
}