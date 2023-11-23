using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        private readonly byte[] _imageData;

        public BookConfiguration()
        {
            _imageData = LoadDefaultImage();
        }

        private byte[] LoadDefaultImage()
        {
            string path = Directory.GetCurrentDirectory();
            string defaultImagePath = Path.Combine(Directory.GetParent(path).FullName,"WebLibMvc", "wwwroot", "images", "default-book-image.jpg");
            byte[] imageData;

            using (var fileStream = new FileStream(defaultImagePath, FileMode.Open))
            {
                using (var memoryStream = new MemoryStream())
                {
                    fileStream.CopyTo(memoryStream);
                    imageData = memoryStream.ToArray();
                }
            }

            return imageData;
        }
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Da Vinci Code",
                    AuthorId = 1,
                    Year = 2003,
                    GenreId = 1,
                    Quantity = 10,
                    ImageData = _imageData
                },
                new Book
                {
                    Id = 2,
                    Title = "Dune",
                    AuthorId = 2,
                    Year = 1965,
                    GenreId = 2,
                    Quantity = 8,
                    ImageData = _imageData
                },
                new Book
                {
                    Id = 3,
                    Title = "Pride and Prejudice",
                    AuthorId = 3,
                    Year = 1813,
                    GenreId = 3,
                    Quantity = 15,
                    ImageData = _imageData
                },
                new Book
                {
                    Id = 4,
                    Title = "The Girl with the Dragon Tattoo",
                    AuthorId = 4,
                    Year = 2005,
                    GenreId = 4,
                    Quantity = 12,
                    ImageData = _imageData
                },
                new Book
                {
                    Id = 5,
                    Title = "Harry Potter and the Sorcerer's Stone",
                    AuthorId = 5,
                    Year = 1997,
                    GenreId = 5,
                    Quantity = 20,
                    ImageData = _imageData
                },
                new Book
                {
                    Id = 6,
                    Title = "The Great Gatsby",
                    AuthorId = 6,
                    Year = 1925,
                    GenreId = 6,
                    Quantity = 18,
                    ImageData = _imageData
                },
                new Book
                {
                    Id = 7,
                    Title = "Steve Jobs",
                    AuthorId = 7,
                    Year = 2011,
                    GenreId = 7,
                    Quantity = 9,
                    ImageData = _imageData
                },
                new Book
                {
                    Id = 8,
                    Title = "The Hobbit",
                    AuthorId = 8,
                    Year = 1937,
                    GenreId = 8,
                    Quantity = 14,
                    ImageData = _imageData
                },
                new Book
                {
                    Id = 9,
                    Title = "It",
                    AuthorId = 9,
                    Year = 1986,
                    GenreId = 9,
                    Quantity = 11,
                    ImageData = _imageData
                },
                new Book
                {
                    Id = 10,
                    Title = "Romeo and Juliet",
                    AuthorId = 10,
                    Year = 1597,
                    GenreId = 10,
                    Quantity = 16,
                    ImageData = _imageData
                },
                 new Book
                 {
                     Id = 11,
                     Title = "The Hound of the Baskervilles",
                     AuthorId = 2,
                     Year = 1902,
                     GenreId = 1,
                     Quantity = 7,
                     ImageData = _imageData
                 },
                 new Book
                 {
                     Id = 12,
                     Title = "Neuromancer",
                     AuthorId = 2,
                     Year = 1984,
                     GenreId = 2,
                     Quantity = 10,
                     ImageData = _imageData
                 },
                 new Book
                 {
                     Id = 13,
                     Title = "Sense and Sensibility",
                     AuthorId = 5,
                     Year = 1811,
                     GenreId = 3,
                     Quantity = 13,
                     ImageData = _imageData
                 },
                 new Book
                 {
                     Id = 14,
                     Title = "The Girl Who Played with Fire",
                     AuthorId = 5,
                     Year = 2006,
                     GenreId = 2,
                     Quantity = 15,
                     ImageData = _imageData
                 },
                 new Book
                 {
                     Id = 15,
                     Title = "Harry Potter and the Chamber of Secrets",
                     AuthorId = 5,
                     Year = 1998,
                     GenreId = 2,
                     Quantity = 18,
                     ImageData = _imageData
                 },
                 new Book
                 {
                     Id = 16,
                     Title = "To Kill a Mockingbird",
                     AuthorId = 6,
                     Year = 1960,
                     GenreId = 6,
                     Quantity = 21,
                     ImageData = _imageData
                 },
                 new Book
                 {
                     Id = 17,
                     Title = "Einstein: His Life and Universe",
                     AuthorId = 7,
                     Year = 2007,
                     GenreId = 7,
                     Quantity = 8,
                     ImageData = _imageData
                 },
                 new Book
                 {
                     Id = 18,
                     Title = "The Lord of the Rings",
                     AuthorId = 8,
                     Year = 1954,
                     GenreId = 7,
                     Quantity = 12,
                     ImageData = _imageData
                 },
                 new Book
                 {
                     Id = 19,
                     Title = "The Shining",
                     AuthorId = 3,
                     Year = 1977,
                     GenreId = 9,
                     Quantity = 14,
                     ImageData = _imageData
                 },
                 new Book
                 {
                     Id = 20,
                     Title = "Macbeth",
                     AuthorId = 10,
                     Year = 1606,
                     GenreId = 10,
                     Quantity = 17,
                     ImageData = _imageData
                 });
        }
    }
}
