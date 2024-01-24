using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Exceptions
{
    public class NotFoundByIdException : Exception
    {

        public NotFoundByIdException(string entity, Guid id)
            : base($"No was find {entity} with this key {id.ToString()}")
        {

        }
    }
}
