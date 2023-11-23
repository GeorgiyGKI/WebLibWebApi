using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Entities.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int ReaderId { get; set; }
        public int BookId { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int TransactionStatusId { get; set; } = 1;

        public Reader Reader { get; set; }
        public Book Book { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
    }

}
