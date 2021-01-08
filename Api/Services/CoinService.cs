using Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Helpers;
using Microsoft.Extensions.Caching.Memory;
using Api.Domain;
using Api.Domain.Models;

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
            var coinJar = GetCoinJar();

            if (coin.CurrencyType != Constants.CurrencyType)
            {
                throw new Exception("CoinJar only accepts only United States Currency!");
            }

            if (Constants.CoinJarTotalVolume < (coinJar.Sum(o => o.Volume) + coin.Volume))
            {
                throw new Exception("CoinJar is full!");
            }

            Coins.Add(coin);
        }

      
        public decimal GetTotalAmount()
        {
            var test = _dbContext.CoinJar.ToList();

            return test.Count();
        }

        private List<CoinJar> GetCoinJar()
        {
            return _dbContext.CoinJar.ToList();
        }

        public void Reset()
        {
            _dbContext.CoinJar.RemoveRange();


        }
    }
}
