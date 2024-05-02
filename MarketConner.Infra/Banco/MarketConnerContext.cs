using MarketConner.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace MarketConner.Infra.Banco
{
    public class MarketConnerContext:DbContext
    {
        public DbSet<Mercado> Mercados { get; set; }


        public MarketConnerContext(DbContextOptions<MarketConnerContext> opt) : base(opt)
        {

        }



    }
}
