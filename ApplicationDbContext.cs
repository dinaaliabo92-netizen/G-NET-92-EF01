using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using G_NET_92_EF02;
namespace G_NET_92_EF02
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Books> Books { get; set; }

        public DbSet<Authors> Authors { get; set; }

        public DbSet<Categories> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreDemo;Trusted_Connection=True;TrustServerCertificate = true");
        }

    }
}
