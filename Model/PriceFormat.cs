using System.Globalization;

namespace BlazingPizza;

/// <summary>
/// Formats prices in US dollars (my country's currency) everywhere in the app.
/// </summary>
public static class PriceFormat
{
    static readonly CultureInfo UnitedStates = CultureInfo.GetCultureInfo("en-US");

    public static string ToCurrency(this decimal amount) => amount.ToString("C", UnitedStates);
}
