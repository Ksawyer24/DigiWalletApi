using DigiWalletApi.Data;
using DigiWalletApi.Models;
using DigiWalletApi.Repos.Interface;
using Microsoft.EntityFrameworkCore;

namespace DigiWalletApi.Repos
{
    public class WalletRepo : IWalletRepo
    {
        private readonly DigiContext digiContext;

        public WalletRepo(DigiContext digiContext)
        {
            this.digiContext = digiContext;
        }
        public async Task<Wallet> CreateAsync(Wallet wallet)
        {
            await digiContext.Wallets.AddAsync(wallet);
            await digiContext.SaveChangesAsync();
            return wallet;
        }

        public async Task<Wallet?> DeleteWalletAsync(Guid id)
        {
            var existing = await digiContext.Wallets.FirstOrDefaultAsync(x => x.Id == id);

            if (existing == null)
            {
                return null;

            }

            digiContext.Wallets.Remove(existing);
            await digiContext.SaveChangesAsync();
            return existing;
        }

        public async Task<List<Wallet>> GetAllWalletsAsync()
        {
            return await digiContext.Wallets.ToListAsync();
        }

        public async Task<Wallet?> GetWalletIdAsync(Guid id)
        {
            return await digiContext.Wallets.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Wallet?> UpdateWalletAsync(Guid id, Wallet wallet)
        {
            var existing = await digiContext.Wallets.FirstOrDefaultAsync(x => x.Id == id);

            if (existing == null)
            {
                return null;

            }

            existing.WalletName = wallet.WalletName;
            await digiContext.SaveChangesAsync();
            return existing;
        }
    }
}
