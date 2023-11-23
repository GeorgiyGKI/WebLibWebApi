using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels.TransactionRepository
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transaction>> GetAllTransactionsAsync(int readerId, bool trackChanges);
        Task<Transaction> GetTransactionAsync(int readerId, int transactionId, bool trackChanges);
        void CreateTransaction(Transaction transaction);
        void DeleteTransaction(Transaction transaction);
    }
}
