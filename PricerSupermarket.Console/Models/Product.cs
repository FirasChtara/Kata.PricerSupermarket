using PricerSupermarket.Console.EnumHelpers;

namespace PricerSupermarket.Console.Models
{
    /// <summary>
    ///  Define the Product class
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

        /// <summary>
        /// Gets or sets the unit.
        /// </summary>
        public Unit Unit { get; set; }

        /// <summary>
        /// Gets or sets the number of unit.
        /// </summary>
        public double NumberOfUnit { get; set; }
    }
}