using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record ReaderDto
    {
        public int Id { get; init; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; init; }
        [Required]
        [StringLength(30)]
        public string LastName { get; init; }
        [Required]
        [StringLength(30)]
        public string Address { get; init; }
        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; init; }
        [Required]
        public DateTime RegistrationDate { get; init; }
    }
}
