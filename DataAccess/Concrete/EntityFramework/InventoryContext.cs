using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class InventoryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=172.17.0.2;Database=DbCBI;User Id=sa;Password=Cbi454567;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer(@"Server=45.12.81.165,1433;Database=DbCBI;User Id=sa;Password=Cbi454567;TrustServerCertificate=True;");

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
