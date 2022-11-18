namespace PricerSupermarket.Console.Models
{
    /// <summary>
    /// Define Cart class
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the cart items.
        /// </summary>
        public List<CartItem> CartItems { get; set; }
    }
}
