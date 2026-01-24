using Microsoft.EntityFrameworkCore;

namespace KaShop.Data
{
    public class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            //db for production
            optionsBuilder.UseSqlServer("Server=db38977.databaseasp.net; Database=db38977; User Id=db38977; Password=n%8WPi?79+Xt; Encrypt=False; MultipleActiveResultSets=True;");
           
            //db for development
            //optionsBuilder.UseSqlServer("Server=.;database=kashop;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
