using KaShop.Models;
using Microsoft.EntityFrameworkCore;

namespace KaShop.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            //db for production
            optionsBuilder.UseSqlServer("Server=db38977.public.databaseasp.net; Database=db38977; User Id=db38977; Password=n%8WPi?79+Xt;" +
                " Encrypt=True; TrustServerCertificate=True;");
           
            //db for development
            //optionsBuilder.UseSqlServer("Server=.;database=kashop;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
