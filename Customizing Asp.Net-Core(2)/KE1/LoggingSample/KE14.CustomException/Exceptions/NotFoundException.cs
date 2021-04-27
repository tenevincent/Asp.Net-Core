using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KE14.CustomException.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        { }
    }
}
