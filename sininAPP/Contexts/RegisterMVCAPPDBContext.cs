using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RegisterMVCAPP.Models;

namespace RegisterMVCAPP.Contexts
{
    public class RegisterMVCAPPDBContext : IdentityDbContext<ApplicationUser>
    {
        public RegisterMVCAPPDBContext() : base()
        {

        }
        public RegisterMVCAPPDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=GAMI;Database=RegisterMVCAPPDB;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
