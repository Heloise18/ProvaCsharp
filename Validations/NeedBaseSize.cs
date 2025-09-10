using System.ComponentModel.DataAnnotations;

namespace prova.Validations;


public class NeedBaseSizeAttribute : ValidationAttribute
{
    
    public override string FormatErrorMessage(string name)
        => $"The field '{name}' cant exceed min 40 and max 200 chars ";
}