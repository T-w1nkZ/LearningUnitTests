using System.Security.Cryptography.X509Certificates;

namespace Challenges.Tests;

public class CalculatorTest
{
    [Fact]
    public void SumIsCorrect()
    {
        int result = Calculator.Sum(1, 5);

        Assert.Equal(6, result);
    }

    [Fact]
    public void SubtractIsCorrect()
    {
        int result = Calculator.Subtract(8, 4);

        Assert.Equal(4, result);
    }
}