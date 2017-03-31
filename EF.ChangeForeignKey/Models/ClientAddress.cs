using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.ChangeForeignKey.Models
{
    public class ClientAddress
    {
        public int ClientAddressId { get; set; }

        public string Street { get; set; }

        public string City { get; set; }
    }
}
