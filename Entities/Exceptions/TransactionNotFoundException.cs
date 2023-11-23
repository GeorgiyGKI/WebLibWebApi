namespace Entities.Exceptions
{
    public sealed class TransactionNotFoundException : NotFoundException
    {
        public TransactionNotFoundException(int transactionId) : base($"The transaction with id: {transactionId} doesn't exist in the database.")
        { }
    }
}