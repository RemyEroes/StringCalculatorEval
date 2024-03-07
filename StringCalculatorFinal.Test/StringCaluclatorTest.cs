using StringCalculatorFinal.Console;

namespace StringCalculatorFinal.Test;

public class StringCaluclatorTest
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(1, 0)]
    public void TestAPlusB(int a, int b)
    {
        var calculatorString = $"{a},{b}";
        var attendu = a + b;
        
        var resultat = StringCalculator.Add(calculatorString);
        Assert.Equal(attendu,resultat);
    }
}

