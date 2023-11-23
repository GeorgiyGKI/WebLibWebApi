using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class TransactionStatusConfiguration : IEntityTypeConfiguration<TransactionStatus>
    {
        public void Configure(EntityTypeBuilder<TransactionStatus> builder)
        {
            builder.HasData(
            new TransactionStatus { Id = 1, Name = "In use" },
            new TransactionStatus { Id = 2, Name = "Returned" },
            new TransactionStatus { Id = 3, Name = "Lost" });
        }
    }
}
