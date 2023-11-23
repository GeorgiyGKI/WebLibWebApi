using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibMVC.ViewModels;

namespace ServiceMVC.TransactionStatusService
{
    public interface ITransactionStatusService
    {
        Task<bool> AddTransactionStatusAsync(TransactionStatusViewModel transactionStatusViewModel);
        Task<bool> DeleteTransactionStatusAsync(int id);
        Task<IEnumerable<TransactionStatusViewModel>> GetAllTransactionStatusesAsync();
        Task<TransactionStatusViewModel> GetTransactionStatusAsync(int id);
        Task<bool> UpdateTransactionStatusAsync(TransactionStatusViewModel transactionStatusViewModel, int id);
    }
}
