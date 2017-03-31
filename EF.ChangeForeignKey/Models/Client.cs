﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.ChangeForeignKey.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        public string Name { get; set; }

        public IList<ClientAddress> ClientAddresses { get; set; }
    }
}
