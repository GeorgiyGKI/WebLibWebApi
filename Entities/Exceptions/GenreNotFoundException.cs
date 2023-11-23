namespace Entities.Exceptions
{
    public sealed class GenreNotFoundException : NotFoundException
    {
        public GenreNotFoundException(int genreId) : base($"The genre with id: {genreId} doesn't exist in the database.")
        { }
    }
}