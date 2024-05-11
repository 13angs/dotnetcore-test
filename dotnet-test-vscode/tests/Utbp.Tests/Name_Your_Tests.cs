namespace Utbp.Tests;
using Utbp.Libs;

public class Name_Your_Tests
{
    // Bad practice
    [Fact]
    public void Test_Single()
    {
        var stringCalculator = new StringCalculator();

        var actual = stringCalculator.Add("0");
        Console.WriteLine($"Name your tests (bad): {actual}");
        Assert.Equal(0, actual);
    }

    // Best practice
    [Fact]
    public void Add_SingleNumber_ReturnsSameNumber()
    {
        var stringCalculator = new StringCalculator();

        var actual = stringCalculator.Add("0");

        Console.WriteLine($"Name your tests (good): {actual}");

        Assert.Equal(0, actual);
    }
}