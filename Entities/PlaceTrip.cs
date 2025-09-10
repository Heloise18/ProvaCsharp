namespace Prova.Entities;

public class PlaceTrip
{
    public Guid ID { get; set; }
    public Guid TripID { get; set; }
    public Guid PlaceId { get; set; }
    public Trip Trips { get; set; }
    public Place Places { get; set; }
}