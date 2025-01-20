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
            var saverRoleId = "41ab8efd-35eb-4c93-8bed-19f320b9d15e";

            var roles = new List<IdentityRole>
            {

            new IdentityRole
            {
                Id = saverRoleId,
                ConcurrencyStamp = saverRoleId,
                Name = "Saver",
                NormalizedName = "SAVER"
            }

            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
