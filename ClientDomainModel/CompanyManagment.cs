using System;
using System.Collections.Generic;
using System.Text;

namespace ClientDomainModel
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }

        public Client(string name = "Unkown", string email = "None entered")
        {
            Name = name;
            Email = email;
            Id = Guid.NewGuid();
            CreatedOn = DateTime.Now;
            IsActive = true;
        }

        public Client(Guid id, string name, string email, DateTime createdOn, bool isActive)
        {
            Id = id;
            Name = name;
            Email = email;
            CreatedOn = createdOn;
            IsActive = isActive;
        }

        public void GetSummary(Client client)
        {
            Console.WriteLine($"Name:{client.Name}");
            Console.WriteLine($"Email:{client.Email}");
            Console.WriteLine($"Id:{client.Id}");
            Console.WriteLine($"Created on:{client.CreatedOn}");
            Console.WriteLine($"Active:{client.IsActive}");
        }
        public void Deactiveate(Client client)
        {
            IsActive = false;
        }
    }
}
