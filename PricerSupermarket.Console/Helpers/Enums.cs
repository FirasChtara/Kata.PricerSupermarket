namespace PricerSupermarket.Console.EnumHelpers;

/// <summary>
/// Define the Unit enumeration
/// </summary>
public enum Unit
{
    /// <summary>
    /// The piece
    /// </summary>
    Piece,

    /// <summary>
    /// The gram
    /// </summary>
    Gram,

    /// <summary>
    /// The ounce
    /// </summary>
    Ounce,

    /// <summary>
    /// The pound
    /// </summary>
    Pound,

    /// <summary>
    /// The kg
    /// </summary>
    Kg
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
    BuyTwoGetOneFree = 1,

    /// <summary>
    /// The three for one dollar
    /// </summary>
    ThreeForOneDollar = 2,

    /// <summary>
    /// The two pounds for one dollar
    /// </summary>
    TwoPoundsForOneDollar = 3
}
