using EF.ChangeForeignKey.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.ChangeForeignKey
{
    public class ClientsContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<ClientAddress> ClientAddresses { get; set; }

        public ClientsContext()
            : base("MyConnection")
        {

        }
    }
}
