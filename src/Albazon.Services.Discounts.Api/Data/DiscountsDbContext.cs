using Albazon.Services.Discounts.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Albazon.Services.Discounts.Api.Data
{
    public class DiscountsDbContext : DbContext
    {

        public DiscountsDbContext(DbContextOptions<DiscountsDbContext> options) : base(options)
        {
        }
        public DbSet<Discount> Discounts { get; set; }
        
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Discount>().HasData(
                new Discount
                {
                    Id = 1,
                    Code = "10OFF",
                    Amount = 10,
                    MinAmount = 20
                },

                new Discount
                {
                    Id = 2,
                    Code = "20OFF",
                    Amount = 20,
                    MinAmount = 40
                }
                );
        }

    }
}
