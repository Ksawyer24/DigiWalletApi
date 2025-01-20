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
    }
}
