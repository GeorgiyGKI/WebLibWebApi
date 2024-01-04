using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class MaxYearRangeBadRequestException : Exception
    {
        public MaxYearRangeBadRequestException() : base("Max age can't be less than min age.")
        {
        }
    }
}
