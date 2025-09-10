using System.ComponentModel.DataAnnotations;

namespace prova.Validations;


public class NeedBaseSizeAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (!(value is string text))
            return false;
       
        int chars = text.Length;

        return chars >= 40 && chars <= 200;
    }
    public override string FormatErrorMessage(string name)
        => $"The field '{name}' cant exceed min 40 and max 200 chars ";
}


