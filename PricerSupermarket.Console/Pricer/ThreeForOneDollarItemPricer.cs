using PricerSupermarket.Console.Models;

namespace PricerSupermarket.Console.Pricer
{
    /// <summary>
    /// Define the Three For One Dollar Item Pricer
    /// </summary>
    public class ThreeForOneDollarItemPricer : ICartItemPricer
    {
        /// <summary>
        /// Prices the specified cart item.
        /// </summary>
        /// <param name="cartItem">The cart item.</param>
        /// <returns></returns>
        public decimal Price(CartItem cartItem)
        {
            decimal price = cartItem.Quantity / 3;

            for (int i = 0; i < cartItem.Quantity % 3; i++)
            {
                price += cartItem.Product.Price;
            }
            
            return price;
        }
    }
}