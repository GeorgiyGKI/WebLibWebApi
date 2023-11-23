using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record AuthorizeDto
    {
        [Required(ErrorMessage = "This field is required")]
        [StringLength(30)]
        public string Name { get; init; }
        [Required(ErrorMessage = "This field is required")]
        [StringLength(30)]
        public string Password { get; init; }
    }
}
