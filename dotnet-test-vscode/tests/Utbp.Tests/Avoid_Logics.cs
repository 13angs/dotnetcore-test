using Utbp.Libs;

namespace Utbp.Tests;

public class Avoid_Logics
{
    // bad
    [Fact]
    public void Add_MultipleNumbers_ReturnsCorrectResults()
    {
        var stringCalculator = new StringCalculator();
        var expected = 0;
        var testCases = new[]
        {
            "0,0,0",
            "0,1,2",
            "1,2,3"
        };

        foreach (var test in testCases)
        {
            Assert.Equal(expected, stringCalculator.Add(test));
            expected += 3;
        }
    }
    // best
    [Theory]
    [InlineData("0,0,0", 0)]
    [InlineData("0,1,2", 3)]
    [InlineData("1,2,3", 6)]
    public void Add_MultipleNumbers_ReturnsSumOfNumbers(string input, int expected)
    {
        var stringCalculator = new StringCalculator();

        var actual = stringCalculator.Add(input);

        Assert.Equal(expected, actual);
    }
}