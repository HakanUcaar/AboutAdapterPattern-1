namespace EasyExchangeRate.Core.Common
{
    /// <summary>
    /// Crc Currency
    /// </summary>
    public class CrcCurrency
    {
        public static EasyCurrency GetCurrencyInfo()
        {
            return EasyCurrency.From(("₡", CurrencyCodes.CRC, "188", "Costa Rican colon"));
        }
    }
}
