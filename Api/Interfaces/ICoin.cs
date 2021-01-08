using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Interfaces
{
    public interface ICoin
    {
        string CurrencyType { get; set; }
        decimal Amount { get; set; }
        decimal Volume { get; set; }
    }

}
