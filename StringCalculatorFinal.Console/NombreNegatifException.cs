namespace StringCalculatorFinal.Console;

public class NombreNegatifException : Exception
{
    public string exceptionMessage = "";
    public NombreNegatifException(List<List<int>> exceptionsPosition) 
    {
        var exceptionString = "";
        foreach (var exception in exceptionsPosition)
        {
            exceptionString+= $"'{exception[0]}' en position {exception[1]} ";
        }

        exceptionMessage = "Des nombres négatifs sont présents: " + exceptionString;
    }
}