namespace Prova.Entities;

public class Trip
{
    public Guid ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid OwnerID { get; set; }
    public User Users { get; set; }

    public ICollection<Place> Attractions = [];
    public ICollection<PlaceTrip> intermediaria = [];


}