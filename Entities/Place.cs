namespace Prova.Entities;

public class Place
{
    public Guid ID { get; set; }
    public string Title { get; set; }
    public Trip Trips { get; set; }

    public ICollection<User> Users = [];
}