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
                return masterList[id];
            }
            else
            {
                Console.WriteLine("Not a client in our database");
                return null;
            }
        }

        public List<Client> GetAllClients()
        {
            return masterList.Values.ToList();
        }

        public List<Client> GetActiveClients()
        {
            List<Client> activeClients = new List<Client>();

            foreach (Client client in masterList.Values)
            {
                if (client.IsActive)
                {
                    activeClients.Add(client);
                }
            }
            return activeClients;
        }


    }
}
