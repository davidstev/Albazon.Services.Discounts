using Albazon.Services.Discounts.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Albazon.Services.Discounts.Api.Data
{
    public class DiscountsDbContext : DbContext
    {

        public DiscountsDbContext(DbContextOptions<DiscountsDbContext> options) : base(options)
        {
            public DbSet<Discount> Discounts { get; set; }
        }

    }
}
