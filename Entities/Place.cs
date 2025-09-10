namespace Prova.Entities;

public class Place
{
    public Guid ID { get; set; }
    public string Title { get; set; }

    public ICollection<Trip> Trips = [];
    public ICollection<PlaceTrip> intermediaria = [];
}