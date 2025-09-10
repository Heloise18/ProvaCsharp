using System.ComponentModel.DataAnnotations;

namespace prova.Validations;


public class MaxCharAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (!(value is string text))
            return false;

        int chars = text.Length;
        
        return chars <= 20;

    }
 
    public override string FormatErrorMessage(string name)
        => $"The field '{name}' cant exceed the max 20 chars ";
}