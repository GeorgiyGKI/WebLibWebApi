using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record TransactionDto
    {
        public int Id { get; init; }
        [Required]
        public int ReaderId { get; init; }
        [Required]
        public int BookId { get; init; }
        public DateTime CheckoutDate { get; init; }
        public DateTime? ReturnDate { get; init; }
        public int TransactionStatusId { get; init; } = 1;
    }
}
