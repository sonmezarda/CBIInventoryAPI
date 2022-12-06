using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class ProductContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-MEA3PRN\NEWSQLSERVER; Database=DbCBI;User Id = DESKTOP-MEA3PRN\ardac;Encrypt=False;TrustServerCertificate=True;Integrated Security = SSPI;");
        }

        public DbSet<Product> TBLProducts { get; set; }
    }
}
