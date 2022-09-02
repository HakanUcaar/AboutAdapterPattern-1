namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Btn Currency
    /// </summary>
    public class BtnCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("Nu.", CurrencyCodes.BTN, "064", "Bhutanese ngultrum"));
        }
    }
}
