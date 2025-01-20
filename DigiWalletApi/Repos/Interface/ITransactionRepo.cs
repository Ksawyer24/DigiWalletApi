using DigiWalletApi.Models;

namespace DigiWalletApi.Repos.Interface
{
    public interface ITransactionRepo
    {
        Task<List<Transaction>> GetAllTransactionAsync();

        Task<Transaction?> GetTransactionIdAsync(Guid id);

        Task<Transaction> CreateAsync(Transaction transaction);
    }
}
