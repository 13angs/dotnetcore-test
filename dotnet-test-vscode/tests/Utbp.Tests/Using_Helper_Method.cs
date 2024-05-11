using Utbp.Libs;

namespace Utbp.Tests;

public class Using_Helper_Method
{
    // bad
    private readonly StringCalculator _stringCalculator;
    public Using_Helper_Method()
    {
        _stringCalculator = new StringCalculator();
    }

    [Fact]
    public void Add_TwoNumbers_ReturnsSumOfNumbers1()
    {
        var result = _stringCalculator.Add("0,1");

        Assert.Equal(1, result);
    }

    // best
    [Fact]
    public void Add_TwoNumbers_ReturnsSumOfNumbers2()
    {
        var stringCalculator = CreateDefaultStringCalculator();

        var actual = stringCalculator.Add("0,1");

        Assert.Equal(1, actual);
    }
    private StringCalculator CreateDefaultStringCalculator()
    {
        return new StringCalculator();
    }
}