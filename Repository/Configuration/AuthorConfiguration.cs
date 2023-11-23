using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
                new Author
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    BirthDate = new DateTime(1980, 5, 15),
                    Country = "USA"
                },
                new Author
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    BirthDate = new DateTime(1975, 8, 22),
                    Country = "UK"
                },
                new Author
                {
                    Id = 3,
                    FirstName = "David",
                    LastName = "Johnson",
                    BirthDate = new DateTime(1992, 3, 10),
                    Country = "Canada"
                },
                new Author
                {
                    Id = 4,
                    FirstName = "Emma",
                    LastName = "Brown",
                    BirthDate = new DateTime(1988, 12, 5),
                    Country = "Australia"
                },
                new Author
                {
                    Id = 5,
                    FirstName = "Michael",
                    LastName = "Davis",
                    BirthDate = new DateTime(1972, 7, 8),
                    Country = "Germany"
                },
                new Author
                {
                    Id = 6,
                    FirstName = "Sophia",
                    LastName = "Miller",
                    BirthDate = new DateTime(1985, 9, 20),
                    Country = "France"
                },
                new Author
                {
                    Id = 7,
                    FirstName = "Daniel",
                    LastName = "Wilson",
                    BirthDate = new DateTime(1990, 6, 30),
                    Country = "Japan"
                },
                new Author
                {
                    Id = 8,
                    FirstName = "Olivia",
                    LastName = "Moore",
                    BirthDate = new DateTime(1978, 2, 18),
                    Country = "Brazil"
                },
                new Author
                {
                    Id = 9,
                    FirstName = "Ethan",
                    LastName = "Lee",
                    BirthDate = new DateTime(1983, 11, 12),
                    Country = "South Africa"
                },
                new Author
                {
                    Id = 10,
                    FirstName = "Ava",
                    LastName = "Anderson",
                    BirthDate = new DateTime(1970, 4, 25),
                    Country = "Russia"
                });
        }
    }
}
