namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Irr Currency
    /// </summary>
    public class IrrCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("ريال", CurrencyCodes.IRR, "364", "Iranian Rial"));
        }
    }
}
