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
        
        Random random = new Random();
        int randomA = random.Next();
        int randomB = random.Next();
        yield return [randomA,randomB];
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

    [Fact]
    public void TestAPlusNTermes()
    {
        var a = 0;
        var b = 0;
        var c = 1;
        
        var calculatorString = $"{a},{b},{c}";
        var attendu = a + b + c;
        
        var resultat = StringCalculator.Add(calculatorString);
        Assert.Equal(attendu,resultat);
    }
}

