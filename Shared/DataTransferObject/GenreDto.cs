﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record GenreDto
    {
        public int Id { get; init; }
        [Required]
        [StringLength(15)]
        public string Name { get; init; }
    }
}
