using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RequestFeatures
{
    public class BookParameters : RequestParameters
    {
        public BookParameters() => OrderBy = "quantity";

        public uint MinYear { get; set; }
        public uint MaxYear { get; set; } = int.MaxValue;
        public bool ValidAgeRange => MaxYear > MinYear;
        public string? SearchTerm { get; set; }

    }
}
