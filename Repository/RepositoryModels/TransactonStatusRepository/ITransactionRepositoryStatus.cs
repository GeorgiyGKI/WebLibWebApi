using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels.TransactonStatusRepository
{
    public interface ITransactionStatusRepository
    {
        Task<IEnumerable<TransactionStatus>> GetAllTransactionStatusesAsync(bool trackChanges);
        Task<TransactionStatus> GetTransactionStatusAsync(int transactionStatusId, bool trackChanges);
        void CreateTransactionStatus(TransactionStatus transactionStatus);
        void DeleteTransactionStatus(TransactionStatus transactionStatus);
    }
}
