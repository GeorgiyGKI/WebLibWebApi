using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                 new Genre
                 {
                     Id = 1,
                     Name = "Mystery"
                 },
                 new Genre
                 {
                     Id = 2,
                     Name = "Science Fiction"
                 },
                 new Genre
                 {
                     Id = 3,
                     Name = "Romance"
                 },
                 new Genre
                 {
                     Id = 4,
                     Name = "Thriller"
                 },
                 new Genre
                 {
                     Id = 5,
                     Name = "Fantasy"
                 },
                 new Genre
                 {
                     Id = 6,
                     Name = "Historical Fiction"
                 },
                 new Genre
                 {
                     Id = 7,
                     Name = "Biography"
                 },
                 new Genre
                 {
                     Id = 8,
                     Name = "Adventure"
                 },
                 new Genre
                 {
                     Id = 9,
                     Name = "Horror"
                 },
                 new Genre
                 {
                     Id = 10,
                     Name = "Drama"
                 });
        }
    }
}