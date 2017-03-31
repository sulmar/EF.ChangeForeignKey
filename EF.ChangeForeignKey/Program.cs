using EF.ChangeForeignKey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.ChangeForeignKey
{
    class Program
    {
        static void Main(string[] args)
        {

            AddClientTest();
        }

        private static void AddClientTest()
        {
            using (var context = new ClientsContext())
            {
                var client = new Client
                {
                    Name = "Sulmar",
                    ClientAddresses = new List<ClientAddress>
                    {
                       new ClientAddress { City = "Warszawa", Street = "Powstanców Śląskich"},
                       new ClientAddress  { City = "Bydgoszcz", Street = "Leszczyńskiego" },
                    }
                };

                context.Clients.Add(client);

                context.SaveChanges();
            }
        }
    }
}
