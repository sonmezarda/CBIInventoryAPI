using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class InventoryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-MEA3PRN\NEWSQLSERVER; Database=DbCBI;User Id = DESKTOP-MEA3PRN\ardac;Encrypt=False;TrustServerCertificate=True;Integrated Security = SSPI;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<ProductSpec> ProductSpecs { get; set; }
        public DbSet<SpecList> SpecList { get; set; }
        public DbSet<Spec> Specs { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }


    }
}
