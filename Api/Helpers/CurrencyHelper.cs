using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Helpers
{
    public static class CurrencyHelper
    {
        public static decimal? GetCoinVolume(decimal amount)
        {
            var result = CoinTypes().FirstOrDefault(o => o.Amount == amount)?.Volume;

            return result;
        }
        private static List<CoinViewModel> CoinTypes()
        {
            var coinTypes = new List<CoinViewModel>();

            var cent = new CoinViewModel
            {
                Amount = 1,
                Volume = 0.0122m
            };
            var nickle = new CoinViewModel
            {
                Amount = 5,
                Volume = 0.0243m
            };
            var dime = new CoinViewModel
            {
                Amount = 10,
                Volume = 0.0115m
            };
            var quarter = new CoinViewModel
            {
                Amount = 25,
                Volume = 0.027m
            };

            coinTypes.Add(cent);
            coinTypes.Add(nickle);
            coinTypes.Add(dime);
            coinTypes.Add(quarter);

            return coinTypes;
        }
    }
}
