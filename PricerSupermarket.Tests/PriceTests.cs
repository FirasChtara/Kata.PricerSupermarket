namespace PricerSupermarket.Tests
{
    public class PriceTests
    {
        [Fact]
        public void should_calcul_total_price_of_all_items()
        {
            // Arrange
            var productsList = new List<Product>()
             {
                 new Product
                 {
                    Id = Guid.NewGuid(),
                    Name= "Product Name 1",
                    Price = 120,
                 },
                    new Product
                 {
                    Id = Guid.NewGuid(),
                    Name= "Product Name 2",
                    Price = 145,
                 }
             };

            // Act
            var totalPrice = new Pricer().GetTotalPrice(productsList);

            // Assert
            Assert.Equal(265,totalPrice);   
        }
    }
}