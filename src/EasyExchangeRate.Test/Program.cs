
using EasyExchangeRate.Core.Common;
using EasyExchangeRate.Denmark;
using EasyExchangeRate.Europe;
using EasyExchangeRate.Israel;
using EasyExchangeRate.Turkey;
using System;

namespace EasyExchangeRate.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetAdapterCurrencies();
            GetAdapterRates();

            Console.ReadLine();
        }

        static void GetAdapterCurrencies()
        {
            TurkeyAdapter adapter = new TurkeyAdapter();
            adapter.Currencies.ForEach(c =>
            {
                Console.WriteLine(c.ToString());
            });
        }

        static void GetAdapterRates()
        {
            TurkeyAdapter adapter = new TurkeyAdapter();
            Console.WriteLine($"Base Currency : {adapter.BaseCurrency.Value.Name}");
            Console.WriteLine("Rates :");
            adapter.Rates.ForEach(c =>
            {
                Console.WriteLine($"{c.Value.Currency.Value.Name} = " + c.Value.Amount);
            });
        }

        
    }
}
