namespace StringCalculatorFinal.Console;

public class StringCalculator
{
    public static string Add(string inputString)
    {
        var inputArray = inputString.Split(",");
        var result = 0;
        List<List<int>> exceptionsPosition = [];
        var position = 0;
        foreach (var number in inputArray)
        {
            position += 1;
            var numberWithoutSpaces = number.Replace(" ", "");
            var intNumber = int.Parse(numberWithoutSpaces);

            
            if (intNumber < 0 )
            {
                List<int> newExceptionPos = [intNumber, position];
                exceptionsPosition.Add(newExceptionPos);
            }
            
            result += intNumber;
        }

        if (exceptionsPosition.Count > 0)
        {
            var exceptionString = "";
            foreach (var exception in exceptionsPosition)
            {
                exceptionString+= $"'{exception[0]}' en position {exception[1]} ";
            }

            return "Des nombres négatifs sont présents: " + exceptionString;
        }
        return result.ToString();
    }
}