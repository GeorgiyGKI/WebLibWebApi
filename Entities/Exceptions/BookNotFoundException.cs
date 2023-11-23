namespace Entities.Exceptions
{
    public sealed class BookNotFoundException : NotFoundException
    {
        public BookNotFoundException(int bookId) : base($"The book with id: {bookId} doesn't exist in the database.")
        { }
    }
}