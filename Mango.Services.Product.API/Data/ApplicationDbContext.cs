using Mango.Services.Product.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Product.API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<MangoProduct> MangoProduct { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
    }
}
