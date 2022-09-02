using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExchangeRate.Core
{
    public static class GenericExtensions
    {
        public static void Do<T>(this T obj,Action<T> action)
        {
            if(obj is not null)
            {
                action(obj);
            }
        }
    }
}
