using Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Api.Helpers;
using Api.Domain;
using Api.Domain.Models;

namespace Api.Services
{
    public class CoinService : ICoinJar
    {
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

            var volume = CurrencyHelper.GetCoinVolume(coin.Amount);

            if (volume == null)
            {
                throw new Exception("Not valid United States Currency amount! " +
                    "CoinJar only accepts cents, dimes, nickles and quarters!");
            }

            var newCoin = new CoinJar
            {
                Amount = coin.Amount,
                Volume = volume ?? 0
            };

            _dbContext.CoinJar.Add(newCoin);
            _dbContext.SaveChanges();
        }

      
        public decimal GetTotalAmount()
        {
            return _dbContext.CoinJar.Sum(o => o.Amount);
        }

        private List<CoinJar> GetCoinJar()
        {
            return _dbContext.CoinJar.ToList();
        }

        public void Reset()
        {
            var coinJar = GetCoinJar();

            _dbContext.CoinJar.RemoveRange(coinJar);

            _dbContext.SaveChanges();
        }
    }
}
