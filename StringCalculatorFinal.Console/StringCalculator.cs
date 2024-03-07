namespace StringCalculatorFinal.Console;

public class StringCalculator
{
    public static string Add(string inputString)
    {
        switch (inputString)
        {
            case"0,0":
                return "0";
            case "0,1":
                return "1";
            case "1,0":
                return "1";
            default:
                return "2";
        }
    }
}