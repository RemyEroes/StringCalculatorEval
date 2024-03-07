using StringCalculatorFinal.Console;

namespace StringCalculatorFinal.Test;

public class StringCaluclatorTest
{
    [Fact]
    public void Test0Plus0()
    {
        var a = 0;
        var b = 0;
        var calculatorString = $"{a},{b}";
        var attendu = "0";

        var resultat = StringCalculator.Add(calculatorString);
        Assert.Equal(attendu,resultat);
    }
}

