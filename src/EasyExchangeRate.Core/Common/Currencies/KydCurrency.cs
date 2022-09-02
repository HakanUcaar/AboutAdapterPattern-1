namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Kyd Currency
    /// </summary>
    public class KydCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("$", CurrencyCodes.KYD, "136", "Cayman Islands dollar"));
        }
    }
}
