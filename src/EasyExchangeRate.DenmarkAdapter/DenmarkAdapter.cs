using EasyExchangeRate.Core;
using EasyExchangeRate.Core.Abstraction;
using EasyExchangeRate.Core.Common;
using System;
using System.Globalization;
using System.Xml;

namespace EasyExchangeRate.Denmark
{
    public class DenmarkAdapter : AbstractExchangeRateAdapter
    {
        public override SourceInfo Source => new SourceInfo()
        {
            Name = "Danmarks Nationalbank",
            Url = "https://www.nationalbanken.dk/_vti_bin/DN/DataService.svc/CurrencyRatesXML?lang=da",
            Unit = 100
        };

        public override EasyCurrency BaseCurrency => DkkCurrency.GetCurrencyInfo();
        public DenmarkAdapter()
        {
            AddCurrency(UsdCurrency.GetCurrencyInfo());
            AddCurrency(JpyCurrency.GetCurrencyInfo());
            AddCurrency(BgnCurrency.GetCurrencyInfo());
            AddCurrency(CzkCurrency.GetCurrencyInfo());
            AddCurrency(DkkCurrency.GetCurrencyInfo());
            AddCurrency(GbpCurrency.GetCurrencyInfo());
            AddCurrency(HufCurrency.GetCurrencyInfo());
            AddCurrency(PlnCurrency.GetCurrencyInfo());
            AddCurrency(RonCurrency.GetCurrencyInfo());
            AddCurrency(SekCurrency.GetCurrencyInfo());
            AddCurrency(ChfCurrency.GetCurrencyInfo());
            AddCurrency(IskCurrency.GetCurrencyInfo());
            AddCurrency(NokCurrency.GetCurrencyInfo());
            AddCurrency(HrkCurrency.GetCurrencyInfo());
            AddCurrency(TryCurrency.GetCurrencyInfo());
            AddCurrency(AudCurrency.GetCurrencyInfo());
            AddCurrency(BrlCurrency.GetCurrencyInfo());
            AddCurrency(CadCurrency.GetCurrencyInfo());
            AddCurrency(CnyCurrency.GetCurrencyInfo());
            AddCurrency(HkdCurrency.GetCurrencyInfo());
            AddCurrency(IdrCurrency.GetCurrencyInfo());
            AddCurrency(IlsCurrency.GetCurrencyInfo());
            AddCurrency(InrCurrency.GetCurrencyInfo());
            AddCurrency(KrwCurrency.GetCurrencyInfo());
            AddCurrency(MxnCurrency.GetCurrencyInfo());
            AddCurrency(MyrCurrency.GetCurrencyInfo());
            AddCurrency(NzdCurrency.GetCurrencyInfo());
            AddCurrency(PhpCurrency.GetCurrencyInfo());
            AddCurrency(SgdCurrency.GetCurrencyInfo());
            AddCurrency(ThbCurrency.GetCurrencyInfo());
            AddCurrency(ZarCurrency.GetCurrencyInfo());

            GetCurrencies();
        }

        public sealed override void GetCurrencies()
        {
            var doc = new XmlDocument();
            doc.Load(Source.Url);

            XmlNodeList nodes = doc.SelectNodes("//*[@code]");

            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    this.Currencies.Find(x => x.Value.IsoCode.ToString() == node.Attributes["code"].Value).Do(currency =>
                    {
                        var rate = Decimal.Parse(node.Attributes["rate"].Value.Replace(",","."), NumberStyles.Currency, new CultureInfo("en-Us"))/Source.Unit;
                        this.Rates.Add(EasyMoney.From((rate, currency)));
                    });
                }
            }
        }
    }
}
