using DigiWalletApi.Models;

namespace DigiWalletApi.Repos.Interface
{
    public interface IWalletRepo
    {
        Task<List<Wallet>> GetAllWalletsAsync();

        Task<Wallet?> GetWalletIdAsync(Guid id);

        Task<Wallet> CreateAsync(Wallet wallet);

        Task<Wallet?> UpdateWalletAsync(Guid id, Wallet wallet);

        Task<Wallet?> DeleteWalletAsync(Guid id);
    }
}
