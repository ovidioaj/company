using Company.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Company.Web.Business
{
    public class AppContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        public AppContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static AppContext Create()
        {
            return new AppContext();
        }
    }
}