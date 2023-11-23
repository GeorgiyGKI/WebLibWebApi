namespace Entities.Exceptions
{
    public sealed class ReaderNotFoundException : NotFoundException
    {
        public ReaderNotFoundException(int readerId) : base($"The reader with id: {readerId} doesn't exist in the database.")
        { }
    }
}