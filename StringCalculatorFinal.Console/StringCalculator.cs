namespace StringCalculatorFinal.Console;

public class StringCalculator
{
    public static int Add(string inputString)
    {
        var inputArray = inputString.Split(",");
        var result = AddidtionFromArray(inputArray);
        return result;
    }

    private static int AddidtionFromArray(string[] inputArray)
    {
        var result = 0;
        List<List<int>> exceptionsPosition = [];
        var position = 0;
        foreach (var number in inputArray)
        {
            position += 1;
            var numberWithoutSpaces = number.ToString().Replace(" ", "");
            var intNumber = int.Parse(numberWithoutSpaces);

            
            if (intNumber < 0 )
            {
                List<int> newExceptionPos = [intNumber, position];
                exceptionsPosition.Add(newExceptionPos);
            }
            
            result += intNumber;
        }

        CheckNegativeNumber(exceptionsPosition);
        return result;
    }

    private static void CheckNegativeNumber(List<List<int>> exceptionsPosition)
    {
        if (exceptionsPosition.Count > 0)
        {
            throw new NombreNegatifException(exceptionsPosition);
        }
    }
    
}

