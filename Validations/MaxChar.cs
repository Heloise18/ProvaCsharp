using System.ComponentModel.DataAnnotations;

namespace prova.Validations;


public class MaxCharAttribute : ValidationAttribute
{
    
    public override string FormatErrorMessage(string name)
        => $"The field '{name}' cant exceed the max 20 chars ";
}