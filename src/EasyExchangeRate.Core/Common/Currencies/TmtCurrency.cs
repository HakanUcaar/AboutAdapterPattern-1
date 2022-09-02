namespace EasyExchangeRate.Core.Common
{
    public class TmtCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("m.", CurrencyCodes.TMT, "934", "Turkmenistani Manat"));
        }
    }
}
