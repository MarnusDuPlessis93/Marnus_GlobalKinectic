using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Models
{
    public class CoinJar
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
    }
}
