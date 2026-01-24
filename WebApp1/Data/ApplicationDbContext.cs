using Microsoft.EntityFrameworkCore;

namespace KaShop.Data
{
    public class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;database=kashop;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
