using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class ReaderConfiguration : IEntityTypeConfiguration<Reader>
    {
        public void Configure(EntityTypeBuilder<Reader> builder)
        {
            builder.HasData(
                new Reader
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Address = "123 Main St",
                    PhoneNumber = "555-1234",
                    RegistrationDate = DateTime.Now,
                },
                new Reader
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Address = "456 Oak St",
                    PhoneNumber = "555-5678",
                    RegistrationDate = DateTime.Now,
                },
                new Reader
                {
                    Id = 3,
                    FirstName = "Robert",
                    LastName = "Johnson",
                    Address = "789 Pine St",
                    PhoneNumber = "555-9101",
                    RegistrationDate = DateTime.Now,
                },
                new Reader
                {
                    Id = 4,
                    FirstName = "Emily",
                    LastName = "Williams",
                    Address = "101 Elm St",
                    PhoneNumber = "555-1212",
                    RegistrationDate = DateTime.Now,
                },
                new Reader
                {
                    Id = 5,
                    FirstName = "Michael",
                    LastName = "Brown",
                    Address = "202 Birch St",
                    PhoneNumber = "555-1414",
                    RegistrationDate = DateTime.Now,
                },
                new Reader
                {
                    Id = 6,
                    FirstName = "Olivia",
                    LastName = "Jones",
                    Address = "303 Maple St",
                    PhoneNumber = "555-1616",
                    RegistrationDate = DateTime.Now,
                },
                new Reader
                {
                    Id = 7,
                    FirstName = "William",
                    LastName = "Davis",
                    Address = "404 Cedar St",
                    PhoneNumber = "555-1818",
                    RegistrationDate = DateTime.Now,
                },
                new Reader
                {
                    Id = 8,
                    FirstName = "Sophia",
                    LastName = "Miller",
                    Address = "505 Redwood St",
                    PhoneNumber = "555-2020",
                    RegistrationDate = DateTime.Now,
                },
                new Reader
                {
                    Id = 9,
                    FirstName = "James",
                    LastName = "Wilson",
                    Address = "606 Pine St",
                    PhoneNumber = "555-2222",
                    RegistrationDate = DateTime.Now,
                },
                new Reader
                {
                    Id = 10,
                    FirstName = "Emma",
                    LastName = "Moore",
                    Address = "707 Oak St",
                    PhoneNumber = "555-2424",
                    RegistrationDate = DateTime.Now,
                });
        }
    }
}
