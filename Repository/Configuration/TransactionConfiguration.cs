using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasData(
                new Transaction
                {
                    Id = 1,
                    ReaderId = 1,
                    BookId = 1,
                    CheckoutDate = DateTime.Now.AddDays(-5),
                    TransactionStatusId = 1,
                },
                new Transaction
                {
                    Id = 2,
                    ReaderId = 2,
                    BookId = 3,
                    CheckoutDate = DateTime.Now.AddDays(-10),
                    ReturnDate = DateTime.Now.AddDays(-5),
                    TransactionStatusId = 2,
                },
                new Transaction
                {
                    Id = 3,
                    ReaderId = 3,
                    BookId = 2,
                    CheckoutDate = DateTime.Now.AddDays(-8),
                    TransactionStatusId = 1,
                },
                new Transaction
                {
                    Id = 4,
                    ReaderId = 4,
                    BookId = 5,
                    CheckoutDate = DateTime.Now.AddDays(-15),
     
                    TransactionStatusId = 3,
                },
                new Transaction
                {
                    Id = 5,
                    ReaderId = 5,
                    BookId = 4,
                    CheckoutDate = DateTime.Now.AddDays(-7),
                    ReturnDate = DateTime.Now.AddDays(-1),
                    TransactionStatusId = 2,
                },
                new Transaction
                {
                    Id = 6,
                    ReaderId = 6,
                    BookId = 6,
                    CheckoutDate = DateTime.Now.AddDays(-12),
                    TransactionStatusId = 1,
                },
                new Transaction
                {
                    Id = 7,
                    ReaderId = 7,
                    BookId = 8,
                    CheckoutDate = DateTime.Now.AddDays(-9),
                    TransactionStatusId = 3,
                },
                new Transaction
                {
                    Id = 8,
                    ReaderId = 8,
                    BookId = 7,
                    CheckoutDate = DateTime.Now.AddDays(-14),
                    ReturnDate = DateTime.Now.AddDays(-8),
                    TransactionStatusId = 2,
                },
                new Transaction
                {
                    Id = 9,
                    ReaderId = 9,
                    BookId = 10,
                    CheckoutDate = DateTime.Now.AddDays(-11),
                    TransactionStatusId = 1,
                },
                new Transaction
                {
                    Id = 10,
                    ReaderId = 10,
                    BookId = 9,
                    CheckoutDate = DateTime.Now.AddDays(-13),
                    TransactionStatusId = 3,
                },
                new Transaction
                {
                    Id = 11,
                    ReaderId = 1,
                    BookId = 7,
                    CheckoutDate = DateTime.Now.AddDays(-6),
                    TransactionStatusId = 1,
                },
                new Transaction
                {
                    Id = 12,
                    ReaderId = 2,
                    BookId = 9,
                    CheckoutDate = DateTime.Now.AddDays(-9),
                    TransactionStatusId = 3,
                },
                new Transaction
                {
                    Id = 13,
                    ReaderId = 3,
                    BookId = 8,
                    CheckoutDate = DateTime.Now.AddDays(-7),
                    ReturnDate = DateTime.Now.AddDays(-3),
                    TransactionStatusId = 2,
                },
                new Transaction
                {
                    Id = 14,
                    ReaderId = 4,
                    BookId = 10,
                    CheckoutDate = DateTime.Now.AddDays(-11),
                    ReturnDate = DateTime.Now.AddDays(-6),
                    TransactionStatusId = 2,
                },
                new Transaction
                {
                    Id = 15,
                    ReaderId = 5,
                    BookId = 6,
                    CheckoutDate = DateTime.Now.AddDays(-8),
                    ReturnDate = DateTime.Now.AddDays(-1),
                    TransactionStatusId = 2,
                },
                new Transaction
                {
                    Id = 16,
                    ReaderId = 6,
                    BookId = 4,
                    CheckoutDate = DateTime.Now.AddDays(-13),
                    ReturnDate = DateTime.Now.AddDays(-7),
                    TransactionStatusId = 2,
                },
                new Transaction
                {
                    Id = 17,
                    ReaderId = 7,
                    BookId = 5,
                    CheckoutDate = DateTime.Now.AddDays(-10),
                    ReturnDate = DateTime.Now.AddDays(-4),
                    TransactionStatusId = 3,
                },
                new Transaction
                {
                    Id = 18,
                    ReaderId = 8,
                    BookId = 3,
                    CheckoutDate = DateTime.Now.AddDays(-12),
                    ReturnDate = DateTime.Now.AddDays(-6),
                    TransactionStatusId = 2,
                },
                new Transaction
                {
                    Id = 19,
                    ReaderId = 9,
                    BookId = 2,
                    CheckoutDate = DateTime.Now.AddDays(-7),
                    ReturnDate = DateTime.Now.AddDays(-2),
                    TransactionStatusId = 2,
                },
                new Transaction
                {
                    Id = 20,
                    ReaderId = 10,
                    BookId = 1,
                    CheckoutDate = DateTime.Now.AddDays(-9),
                    ReturnDate = DateTime.Now.AddDays(-3),
                    TransactionStatusId = 2,
                });
        }
    }
}
