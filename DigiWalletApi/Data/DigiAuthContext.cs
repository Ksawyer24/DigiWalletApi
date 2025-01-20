using DigiWalletApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DigiWalletApi.Data
{
    public class DigiAuthContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public DigiAuthContext(DbContextOptions<DigiAuthContext> options) : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Roles into Database
            var saverRoleId = Guid.Parse("cab418b8-0fb1-4808-9b13-69fdde71721c");

            var roles = new List<IdentityRole<Guid>>
            {

            new IdentityRole<Guid>
            {
                Id = saverRoleId,
                ConcurrencyStamp = saverRoleId.ToString(),
                Name = "Saver",
                NormalizedName = "SAVER"
            }

            };

            modelBuilder.Entity<IdentityRole<Guid>>().HasData(roles);

        }
    }
}
