using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventReservationPlatform.Core.Entities
{
    public class Enterprise
    {
        public Enterprise(string name, int federalCode)
        {
            Name = name;
            FederalCode = federalCode;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int FederalCode { get; set; }
    }
}
