namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Mdl Currency
    /// </summary>
    public class MdlCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("L", CurrencyCodes.MDL, "498", "Moldovan Leu"));
        }
    }
}
