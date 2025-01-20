using DigiWalletApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DigiWalletApi.Data
{
    public class DigiContext:DbContext
    {
        public DigiContext(DbContextOptions<DigiContext> contextOptions) :base(contextOptions) 
        {
            
        }


        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Wallet> Wallets { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



            builder.Entity<User>()
          .HasMany(u => u.Wallets) // User has many wallets
           . WithOne(w => w.User)     // Each wallet is associated with one user
          .HasForeignKey(w => w.UserId) // The foreign key in Wallet referencing User
          .OnDelete(DeleteBehavior.Cascade); // Cascade delete: Delete a user and their wallets


            //Transaction Configuration
              builder.Entity<Transaction>()
                  .HasOne(t => t.Wallet)
                  .WithMany(w => w.Transactions)
                  .HasForeignKey(t => t.WalletId);
                
        }

    }
}
