using PricerSupermarket.Console.EnumHelpers;
using System.Diagnostics.CodeAnalysis;

namespace PricerSupermarket.Console.Helpers;

/// <summary>
/// Define the Helpers class
/// </summary>
[ExcludeFromCodeCoverage]
public static class Helpers
{
    /// <summary>
    /// Converts to pound.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="fromUnit">From unit.</param>
    public static double ToPound(this double value, Unit fromUnit)
    {
        switch (fromUnit)
        {
            case Unit.Piece: throw new InvalidOperationException("Not Supported Convertion");
            case Unit.Gram: return Constants.GramToPoundConvertion * value;
            case Unit.Ounce: return Constants.OunceToPoundConvertion * value;
            case Unit.Pound: return value;
            case Unit.Kg: return Constants.KgToPoundConvertion * value;
            default: return value;
        }
    }

}