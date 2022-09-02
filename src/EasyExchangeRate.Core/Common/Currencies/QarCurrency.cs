namespace EasyExchangeRate.Core.Common
{
    public class QarCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("ر.ق.", CurrencyCodes.QAR, "634", "Qatari Rial"));
        }
    }
}
