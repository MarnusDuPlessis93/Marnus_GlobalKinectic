using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Domain
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GlobalKinetic;Trusted_Connection=True;");
        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<CoinJar> CoinJar { get; set; }
    }
}
