namespace Prova.Entities;

public class VisitorsPlaces
{
    public Guid ID { get; set; }
    public Guid UserID { get; set; }
    public Guid PlaceId { get; set; }
    public User Users { get; set; }
    public Place Places { get; set; }
}