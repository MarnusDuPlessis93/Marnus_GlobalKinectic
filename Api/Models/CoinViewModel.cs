using Api.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class CoinViewModel : ICoin
    {
        [Required]
        public string CurrencyType { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
    }
}
