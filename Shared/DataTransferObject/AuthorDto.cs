using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record AuthorDto
    {
        public int Id { get; init; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; init; }
        [Required]
        [StringLength(30)]
        public string LastName { get; init; }
        [Required]
        public DateTime BirthDate { get; init; }
        [Required]
        [StringLength(30)]
        public string Country { get; init; }
    }
}
