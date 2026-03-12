using ClientDomainModel;
using CompanyMangementServices;
public class Program
{
    static void Main()
    {
        Client client = new Client("Isaac", "someEmail");
        client.GetSummary(client);

        Client client2 = new Client("Ya boi", "yaBoisEmail");
        client2.Deactiveate(client2);
        client2.GetSummary(client2);

        Client client3 = new Client();

        ClientRepository repo = new ClientRepository();
        repo.AddClient(client2);
        repo.AddClient(client3);
        repo.AddClient(client);
        Client isClient = repo.GetClientById(client2.Id);
        Console.WriteLine(isClient.Name);

       List<Client> allOfThem = repo.GetAllClients();
        foreach (var person in allOfThem)
        {
            Console.WriteLine(person.Name);
        }
        List<Client> allActiveClients = repo.GetActiveClients();
        foreach (var active in allActiveClients)
        {
            Console.WriteLine(active.Name);
        }

    }
}
