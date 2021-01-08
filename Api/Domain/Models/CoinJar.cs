using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
