namespace StringCalculatorFinal.Console;

public class StringCalculator
{
    public static int Add(string inputString)
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
            throw new NombreNegatifException(exceptionsPosition);
        }
        return result;
    }
}

