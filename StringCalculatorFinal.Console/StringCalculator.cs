namespace StringCalculatorFinal.Console;

public class StringCalculator
{
    public static int Add(string inputString)
    {
        var inputArray = inputString.Split(",");
        var result = 0;
        foreach (var number in inputArray)
        {
            result += int.Parse(number);
        }
        return result;
    }
}