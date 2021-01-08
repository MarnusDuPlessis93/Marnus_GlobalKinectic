using Api.Domain;
using Api.Interfaces;
using Api.Services;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace Marnus_GlobalKinectic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var coinService = new CoinService(new Context());

            coinService.GetTest();

            Console.WriteLine("Hello World!");
        }

    }

}
