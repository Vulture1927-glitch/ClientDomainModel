using ClientDomainModel;
public class Program
{
    static void Main()
    {
        Client client = new Client("Isaac", "someEmail");
        client.GetSummary(client);

    }
}
