namespace Prova.Entities;

public class User
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public Guid Password { get; set; }

    public ICollection<Trip> Trips = [];
    public ICollection<Place> Places = [];


}