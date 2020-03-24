using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MishaShop.Models
{
    public class CustomerContext : IdentityDbContext<IdentityUser>
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
            Database.Migrate();
        }
    }
}
