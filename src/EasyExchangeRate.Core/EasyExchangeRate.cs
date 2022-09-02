using EasyExchangeRate.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Core
{
    public class EasyExchangeRate
    {
        private static readonly HashSet<IExchangeRateAdapter> Adapters = new HashSet<IExchangeRateAdapter>();
        public EasyExchangeRate()
        {

        }

        public HashSet<IExchangeRateAdapter> GetAdapters()
        {
            return Adapters;
        }
        public void AddAdapter(IExchangeRateAdapter adapter)
        {
            Adapters.Add(adapter);
        }
    }
}
