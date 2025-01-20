using DigiWalletApi.Data;
using DigiWalletApi.Models;
using DigiWalletApi.Repos.Interface;
using Microsoft.EntityFrameworkCore;

namespace DigiWalletApi.Repos
{
    public class TransactionRepo : ITransactionRepo
    {
        private readonly DigiContext digiContext;

        public TransactionRepo(DigiContext digiContext)
        {
            this.digiContext = digiContext;
        }
        public async Task<Transaction> CreateAsync(Transaction transaction)
        {
            await digiContext.AddAsync(transaction);
            await digiContext.SaveChangesAsync();
            return transaction; 

        }

        public async Task<List<Transaction>> GetAllTransactionAsync()
        {
            return await digiContext.Transactions.ToListAsync();
        }

        public async Task<Transaction?> GetTransactionIdAsync(Guid id)
        {
           return await digiContext.Transactions.FirstOrDefaultAsync(x=> x.Id == id);
        }
    }
}
