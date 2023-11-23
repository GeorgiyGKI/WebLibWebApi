using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TransactionStatusService
{
    public interface ITransactionStatusService
    {
        
            Task<IEnumerable<TransactionStatusDto>> GetAllTransactionStatusesAsync(bool trackChanges);
            Task<TransactionStatusDto> GetTransactionStatusAsync(int id, bool trackChanges);
            Task<TransactionStatusDto> CreateTransactionStatusAsync(TransactionStatusDto transactionStatus);
            Task DeleteTransactionStatusAsync(int id, bool trackChanges);
            Task UpdateTransactionStatusAsync(int id, TransactionStatusDto transactionStatusForUpdate, bool trackChanges);
        
    }
}
