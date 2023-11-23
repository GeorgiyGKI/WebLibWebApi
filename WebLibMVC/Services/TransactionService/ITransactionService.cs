using WebLibMVC.ViewModels;

namespace ServiceMVC.TransactionService
{
    public interface ITransactionService
    {
        Task<bool> AddTransactionAsync(TransactionViewModel transactionViewModel);
        Task<bool> DeleteTransactionAsync(int readerId, int id);
        Task<IEnumerable<TransactionViewModel>> GetAllTransactionsAsync(int readerId);
        Task<TransactionViewModel> GetTransactionAsync(int readerId, int id);
        Task<bool> UpdateTransactionAsync(TransactionViewModel transactionViewModel, int readerId, int id);
        Task<bool> CloseTransactionAsync(int readerId, int id);
    }
}
    