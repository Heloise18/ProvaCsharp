using System.ComponentModel.DataAnnotations;
using prova.Validations;

namespace prova.Payload;
public record TripData(

    [MaxChar]
    [Required]
    string Title,
    
    [NeedBaseSize]
    string Description
);


    