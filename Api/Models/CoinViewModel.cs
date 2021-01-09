using Api.Interfaces;
using System.ComponentModel.DataAnnotations;

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
