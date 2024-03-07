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
    
    
    [Theory]
    [InlineData("0,0,1", 1)]
    [InlineData("1,0,1,1",3)]
    [InlineData("1,0,3,1",5)]
    [InlineData("0,0,3,1",4)]
    public void TestAPlusNTermes(string inputString, int attendu)
    {
        var resultat = StringCalculator.Add(inputString);
        Assert.Equal(attendu,resultat);
    }

    [Fact]
    public void TestAPlusNtermsAvecEspace()
    {
        var inputString = "0 , 0,1 ";
        var attendu = 1;
        
        var resultat = StringCalculator.Add(inputString);
        Assert.Equal(attendu,resultat);
    }
}

