using Utbp.Libs;

namespace Utbp.Tests;

public class Avoid_Magic_Strings
{
    // bad
    [Fact]
    public void Add_BigNumber_ThrowsException()
    {
        var stringCalculator = new StringCalculator();

        Action actual = () => stringCalculator.Add("1001");

        Assert.Throws<OverflowException>(actual);
    }

    // best
    [Fact]
    void Add_MaximumSumResult_ThrowsOverflowException()
    {
        var stringCalculator = new StringCalculator();
        const string MAXIMUM_RESULT = "1001";

        Action actual = () => stringCalculator.Add(MAXIMUM_RESULT);

        Assert.Throws<OverflowException>(actual);
    }
}