namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Ugx Currency
    /// </summary>
    public class UgxCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("USh", CurrencyCodes.UGX, "800", "Ugandan shilling"));
        }
    }
}
