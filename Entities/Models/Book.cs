using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int Year { get; set; }
        public int GenreId { get; set; }
        public int Quantity { get; set; }
        public int DefaultQuantity { get; set; }
        public byte[]? ImageData { get; set; }

        public Author Author { get; set; }
        public Genre Genre { get; set; }
    }
}
