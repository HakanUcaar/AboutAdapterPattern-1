using EasyExchangeRate.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Core.Abstraction
{
    public abstract class AbstractExchangeRateAdapter : IExchangeRateAdapter
    {
        private List<EasyCurrency> _currencies { get; set; } = new List<EasyCurrency>();
        public List<EasyCurrency> Currencies => _currencies;

        public virtual DateTime Date { get; }
        public virtual EasyCurrency BaseCurrency { get; }
        public virtual SourceInfo Source { get; }
        public List<EasyMoney> Rates { get; set; } = new List<EasyMoney>();

        public void AddCurrency(EasyCurrency currency)
        {
            _currencies.Add(currency);
        }

        public abstract void GetCurrencies();
    }
}
