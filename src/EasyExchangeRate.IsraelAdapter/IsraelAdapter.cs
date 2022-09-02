using EasyExchangeRate.Core;
using EasyExchangeRate.Core.Abstraction;
using EasyExchangeRate.Core.Common;
using System;
using System.Globalization;
using System.Xml;

namespace EasyExchangeRate.Israel
{
    public class IsraelAdapter : AbstractExchangeRateAdapter
    {
        public override SourceInfo Source => new SourceInfo()
        {
            Name = "Bank Of Israel",
            Url = "https://www.boi.org.il/currency.xml",
            Unit = 1
        };

        public override EasyCurrency BaseCurrency => IlsCurrency.GetCurrencyInfo();
        public IsraelAdapter()
        {
            AddCurrency(UsdCurrency.GetCurrencyInfo());
            AddCurrency(GbpCurrency.GetCurrencyInfo());
            AddCurrency(JpyCurrency.GetCurrencyInfo());
            AddCurrency(EurCurrency.GetCurrencyInfo());
            AddCurrency(AudCurrency.GetCurrencyInfo());
            AddCurrency(CadCurrency.GetCurrencyInfo());
            AddCurrency(DkkCurrency.GetCurrencyInfo());
            AddCurrency(NokCurrency.GetCurrencyInfo());
            AddCurrency(ZarCurrency.GetCurrencyInfo());
            AddCurrency(SekCurrency.GetCurrencyInfo());
            AddCurrency(ChfCurrency.GetCurrencyInfo());
            AddCurrency(JodCurrency.GetCurrencyInfo());
            AddCurrency(LbpCurrency.GetCurrencyInfo());
            AddCurrency(EgpCurrency.GetCurrencyInfo());

            GetCurrencies();
        }

        public sealed override void GetCurrencies()
        {
            var doc = new XmlDocument();
            doc.Load(Source.Url);

            XmlNodeList nodes = doc.SelectNodes("//CURRENCY");

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    this.Currencies.Find(x => x.Value.IsoCode.ToString() == node.SelectSingleNode("CURRENCYCODE").InnerText).Do(currency =>
                    {
                        var val = node.SelectSingleNode("RATE").InnerText;
                        var rate = Decimal.Parse((String.IsNullOrEmpty(val) ? "0" : val), NumberStyles.Any, new CultureInfo("en-Us")) / Source.Unit;
                        this.Rates.Add(EasyMoney.From((rate, currency)));
                    });
                }
            }
        }
    }
}
