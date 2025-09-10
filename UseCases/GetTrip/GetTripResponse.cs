using Prova.Entities;

namespace prova.UseCases.CreatTrip;

public record GetTripResponse (
    string Title,
    string Description,
    string Owner,
    ICollection<Place> Attractions

);