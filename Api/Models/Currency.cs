using Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public abstract class UsCoin : ICoin
    {
        public string CurrencyType { get; set; }
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }

        public UsCoin(decimal amount, decimal volume)
        {
            Volume = volume;
            Amount = amount;
        }
    }


    public class Cent : UsCoin
    {

        public Cent() : base(0.0122m, 0.01m) { }

    }

    public class Nickel : UsCoin
    {

        public Nickel() : base(0.0243m, 0.05m) { }

    }

    public class Dime : UsCoin
    {

        public Dime() : base(0.0115m, 0.1m) { }

    }

    public class Quarter : UsCoin
    {

        public Quarter() : base(0.0270m, 0.25m) { }

    }

    public class DollarCoin : UsCoin
    {

        public DollarCoin() : base(0.0900m, 1.0m) { }

    }

}
