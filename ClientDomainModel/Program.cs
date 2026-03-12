using ClientDomainModel;
public class Program
{
    static void Main()
    {
        Client client = new Client("Isaac", "someEmail");
        client.GetSummary(client);

        Client client2 = new Client("Ya boi", "yaBoisEmail");
        client2.Deactiveate(client2);
        client2.GetSummary(client2);

    }
}
