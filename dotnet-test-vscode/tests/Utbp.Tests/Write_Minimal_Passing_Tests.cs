using Utbp.Libs;

namespace Utbp.Tests;
public class Write_Minimal_Passing_Tests
{
    // bad
    [Fact]
    public void Add_SingleNumber_ReturnsSameNumber1()
    {
        var stringCalculator = new StringCalculator();

        var actual = stringCalculator.Add("42");

        Assert.Equal(42, actual);
    }

    // best
    [Fact]
    public void Add_SingleNumber_ReturnsSameNumber2()
    {
        var stringCalculator = new StringCalculator();

        var actual = stringCalculator.Add("0");

        Assert.Equal(0, actual);
    }
}