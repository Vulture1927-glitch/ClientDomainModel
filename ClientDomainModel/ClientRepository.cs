using System;
using System.Collections.Generic;
using System.Text;
using ClientDomainModel;

namespace CompanyMangementServices
{
    public class ClientRepository
    {
        Dictionary<Guid, Client> masterList = new Dictionary<Guid, Client>();


        public void AddClient(Client client)
        {
            masterList.Add(client.Id, client);
        }
        public Client? GetClientById(Guid id)
        {
            if (masterList.ContainsKey(id))
            {
                return masterList[];
            }
            else
            {
                Console.WriteLine("Not a client in our database");
                return null;
            }
        }

        public void GetAllClients()
        {
            foreach (Client client in masterList.Values)
            {
                Console.WriteLine(client);
            }

        }

        public void GetActiveClients()
        {
            foreach (Client client in masterList.Values)
            {
                if (client.IsActive)
                {
                    Console.WriteLine(client);
                }
            }
        }


    }
}
