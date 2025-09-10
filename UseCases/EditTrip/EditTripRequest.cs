namespace prova.UseCases.EditTrip;

public record EditTripRequest (
    Guid TripID,
    Guid PlaceID,
    Guid Ownerid
);