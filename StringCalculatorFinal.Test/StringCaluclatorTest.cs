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
        Assert.Equal(attendu.ToString(),resultat);
    }
    
    
    [Theory]
    [InlineData("0,0,1", 1)]
    [InlineData("1,0,1,1",3)]
    [InlineData("1,0,3,1",5)]
    [InlineData("0,0,3,1",4)]
    public void TestAPlusNTermes(string inputString, int attendu)
    {
        var resultat = StringCalculator.Add(inputString);
        Assert.Equal(attendu.ToString(),resultat);
    }
    
    [Theory]
    [InlineData("1 2,0,1", 13)]
    [InlineData(" 19,0 ,61, 1",81)]
    [InlineData("1 4, 0 0,32, 1   3",59)]
    [InlineData("01,0  2,  33 ,  4 1",77)]
    public void TestAPlusNTermesAvecEspaces(string inputString, int attendu)
    {
        var resultat = StringCalculator.Add(inputString);
        Assert.Equal(attendu.ToString(),resultat);
    }

    [Fact]
    public void TestAvecNombresNégatifs()
    {
        var a = -1;
        var b = 1;
        var calculatorString = $"{a},{b}";
        var attendu = "Des nombres négatifs sont présents: '-1' en position 1 ";
        
        var resultat = StringCalculator.Add(calculatorString);
        Assert.Equal(attendu.ToString(),resultat);
    }
    
    [Fact]
    public void TestAvecNombresNégatifs2()
    {
        var a = 1;
        var b = -1;
        var calculatorString = $"{a},{b}";
        var attendu = "Des nombres négatifs sont présents: '-1' en position 2 ";
        
        var resultat = StringCalculator.Add(calculatorString);
        Assert.Equal(attendu.ToString(),resultat);
    }
}

