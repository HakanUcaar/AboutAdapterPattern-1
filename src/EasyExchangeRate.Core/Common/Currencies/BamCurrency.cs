namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Bam Currency
    /// </summary>
    public class BamCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("КМ", CurrencyCodes.BAM, "977", "Bosnia and Herzegovina convertible mark"));
        }
    }
}
