namespace Entities.Exceptions
{
    public sealed class AuthorNotFoundException : NotFoundException
    {
        public AuthorNotFoundException(int authorId) : base($"The author with id: {authorId} doesn't exist in the database.")
        { }
    }
}