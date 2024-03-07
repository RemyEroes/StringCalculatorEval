namespace StringCalculatorFinal.Console;

public class StringCalculator
{
    public static string Add(string inputString)
    {
        var inputArray = inputString.Split(",");
        var result = 0;
        foreach (var number in inputArray)
        {
            var numberWithoutSpaces = number.Replace(" ", "");
            var intNumber = int.Parse(numberWithoutSpaces);

            if (intNumber < 0)
            {
                return "Des nombres négatifs sont présents: '-1' en position 1 ";
            }
            
            result += intNumber;
        }
        return result.ToString();
    }
}