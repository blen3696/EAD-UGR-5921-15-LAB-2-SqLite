using Microsoft.EntityFrameworkCore;

namespace PizzaStoreSQLite.Models
{
    public class PizzaDb : DbContext
    {
        public PizzaDb(DbContextOptions<PizzaDb> options) : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; } = null!;
    }
}
