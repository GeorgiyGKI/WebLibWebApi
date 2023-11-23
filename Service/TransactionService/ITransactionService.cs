using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TransactionService
{
    public interface ITransactionService
    {
        Task<IEnumerable<TransactionDto>> GetAllTransactionsAsync(int readerId, bool trackChanges);
        Task<TransactionDto> GetTransactionAsync(int readerId, int id, bool trackChanges);
        Task<TransactionDto> CreateTransactionAsync(TransactionDto transaction);
        Task DeleteTransactionAsync(int readerId, int id, bool trackChanges);
        Task UpdateTransactionAsync(int readerId, int id, TransactionDto transactionForUpdate, bool trackChanges);
    }
}
