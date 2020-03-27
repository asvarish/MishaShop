using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MishaShop.Models
{
    public class CustomerContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Good> Goods { get; set; }
        public DbSet<FavouriteGoods> Favourite { get; set; }

        public CustomerContext()      
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=URA.db");
        }
    }
}
