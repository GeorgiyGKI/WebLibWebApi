using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels.TransactionRepository
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        public TransactionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactionsAsync(int readerId, bool trackChanges) =>
            await FindByCondition(Entity => Entity.ReaderId.Equals(readerId), trackChanges).ToListAsync();

        public async Task<Transaction> GetTransactionAsync(int readerId, int transactionId, bool trackChanges) =>
            await FindByCondition(Entity => Entity.ReaderId.Equals(readerId) &&
                                            Entity.Id.Equals(transactionId),
                                            trackChanges).SingleOrDefaultAsync();

        public void CreateTransaction(Transaction transaction) => Create(transaction);

        public void DeleteTransaction(Transaction transaction) => Delete(transaction);
    }
}
