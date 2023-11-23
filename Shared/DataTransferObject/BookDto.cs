using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record BookDto
    {
        public int Id { get; init; }
        [Required]
        [StringLength(30)]
        public string Title { get; init; }
        [Required]
        public int AuthorId { get; init; }
        [Required]
        [Range(0, 9999)]
        public int Year { get; init; }

        [Required]
        public int GenreId { get; init; }
        [Required]
        [Range(1, 99)]
        public int Quantity { get; init; }
        [Required]
        [MaxLength(2 * 1024 * 1024, ErrorMessage = "The image size should not exceed 2 megabytes.")]
        public byte[]? ImageData { get; init; }

    }
}