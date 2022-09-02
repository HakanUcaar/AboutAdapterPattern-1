using EasyExchangeRate.Core;
using EasyExchangeRate.Core.Abstraction;
using EasyExchangeRate.Core.Common;
using System;
using System.Globalization;
using System.Xml;

namespace EasyExchangeRate.Turkey
{
    public class TurkeyAdapter : AbstractExchangeRateAdapter
    {
        public override SourceInfo Source => new SourceInfo()
        {
            Name = "Republic of Turkey Central Bank",
            Url = "https://www.tcmb.gov.tr/kurlar/today.xml",
            Unit = 1
        };

        public override EasyCurrency BaseCurrency => TryCurrency.GetCurrencyInfo();
        public TurkeyAdapter()
        {
            AddCurrency(UsdCurrency.GetCurrencyInfo());
            AddCurrency(AudCurrency.GetCurrencyInfo());
            AddCurrency(DkkCurrency.GetCurrencyInfo());
            AddCurrency(EurCurrency.GetCurrencyInfo());
            AddCurrency(GbpCurrency.GetCurrencyInfo());
            AddCurrency(ChfCurrency.GetCurrencyInfo());
            AddCurrency(SekCurrency.GetCurrencyInfo());
            AddCurrency(CadCurrency.GetCurrencyInfo());
            AddCurrency(KwdCurrency.GetCurrencyInfo());
            AddCurrency(NokCurrency.GetCurrencyInfo());
            AddCurrency(SarCurrency.GetCurrencyInfo());
            AddCurrency(JpyCurrency.GetCurrencyInfo());
            AddCurrency(BgnCurrency.GetCurrencyInfo());
            AddCurrency(RonCurrency.GetCurrencyInfo());
            AddCurrency(RubCurrency.GetCurrencyInfo());
            AddCurrency(IrrCurrency.GetCurrencyInfo());
            AddCurrency(CnyCurrency.GetCurrencyInfo());
            AddCurrency(PkrCurrency.GetCurrencyInfo());
            AddCurrency(QarCurrency.GetCurrencyInfo());
            AddCurrency(KrwCurrency.GetCurrencyInfo());
            AddCurrency(AznCurrency.GetCurrencyInfo());
            AddCurrency(AedCurrency.GetCurrencyInfo());
            AddCurrency(XdrCurrency.GetCurrencyInfo());

            GetCurrencies();
        }

        public sealed override void GetCurrencies()
        {
            var doc = new XmlDocument();
            doc.Load(Source.Url);

            XmlNodeList nodes = doc.SelectNodes("//*[@CurrencyCode]");

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    this.Currencies.Find(x => x.Value.IsoCode.ToString() == node.Attributes["CurrencyCode"].Value).Do(currency =>
                    {
                        var val = node.SelectSingleNode("ForexBuying").InnerText;
                        var rate = Decimal.Parse((String.IsNullOrEmpty(val) ? "0" : val) , NumberStyles.Any, new CultureInfo("en-Us")) / Source.Unit;
                        this.Rates.Add(EasyMoney.From((rate, currency)));
                    });
                }
            }
        }
    }
}
