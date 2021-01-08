using Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Helpers;
using Microsoft.Extensions.Caching.Memory;
using Api.Domain;

namespace Api.Services
{
    public class CoinService : ICoinJar
    {
        private readonly List<ICoin> Coins;
        private IMemoryCache _cache;
        private readonly Context _dbContext;

        public CoinService(Context context)
        {
            _dbContext = context;
        }
        public void AddCoin(ICoin coin)
        {
            var test = _dbContext.CoinJar;


            if (coin.CurrencyType != Constants.CurrencyType)
            {
                throw new Exception("CoinJar only accepts only United States Currency!");
            }

            if (Constants.CoinJarTotalVolume < (Coins.Sum(o => o.Volume) + coin.Volume))
            {
                throw new Exception("CoinJar is full!");
            }

            Coins.Add(coin);


            //test.Value = coin.
        }

        public void GetTest()
        {
            var test = _dbContext.CoinJar.ToList();
        }

        public decimal GetTotalAmount()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
