using StringCalculatorFinal.Console;

namespace StringCalculatorFinal.Test;

public class StringCaluclatorTest
{
    
    public static IEnumerable<object[]> casAPlusB()
    {
        yield return [0,0];
        yield return [0,1];
        yield return [1,0];
        yield return [1,1];
    }
    
    [Theory]
    [MemberData(nameof(casAPlusB))]
    public void TestAPlusB(int a, int b)
    {
        var calculatorString = $"{a},{b}";
        var attendu = a + b;
        
        var resultat = StringCalculator.Add(calculatorString);
        Assert.Equal(attendu,resultat);
    }
}

