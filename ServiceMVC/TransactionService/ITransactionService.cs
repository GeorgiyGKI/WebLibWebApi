namespace ServiceMVC.TransactionService
{
    public interface ITransactionService
    {
        Task<bool> AddTransactionAsync(TransactionViewModel transactionViewModel);
        Task<bool> DeleteTransactionAsync(int id);
        Task<IEnumerable<TransactionViewModel>> GetAllTransactionsAsync();
        Task<TransactionViewModel> GetTransactionAsync(int id);
        Task<bool> UpdateTransactionAsync(TransactionViewModel transactionViewModel, int id);
    }
}
