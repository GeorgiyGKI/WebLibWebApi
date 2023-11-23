namespace Entities.Exceptions
{
    public sealed class TransactionStatusNotFoundException : NotFoundException
    {
        public TransactionStatusNotFoundException(int transactionStatusId) : base($"The transaction status with id: {transactionStatusId} doesn't exist in the database.")
        { }
    }
}