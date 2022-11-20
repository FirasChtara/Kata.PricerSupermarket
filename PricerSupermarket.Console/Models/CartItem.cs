using PricerSupermarket.Console.EnumHelpers;

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
        public double Quantity { get; set; }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets the promotion.
        /// </summary>
        public Promotion Promotion { get; set; }

        public Unit Unit { get; set; }
    }
}