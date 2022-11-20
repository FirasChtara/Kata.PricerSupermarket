namespace PricerSupermarket.Console.EnumHelpers
{
    /// <summary>
    /// Define the Unit enumeration
    /// </summary>
    public enum Unit
    {
        /// <summary>
        /// The Piece
        /// </summary>
        Piece = 0,
        /// <summary>
        /// The weight in Kg
        /// </summary>
        Weight = 1,
    }

    /// <summary>
    /// Define the Promotion enumeration
    /// </summary>
    public enum Promotion
    {
        /// <summary>
        /// The without promotion
        /// </summary>
        WithoutPromotion = 0,

        /// <summary>
        /// The by two get one free
        /// </summary>
        ByTwoGetOneFree = 1 ,

        /// <summary>
        /// The three for one dollar
        /// </summary>
        ThreeForOneDollar = 2,

        /// <summary>
        /// The two pounds for one dollar
        /// </summary>
        TwoPoundsForOneDollar = 3
    }
}
