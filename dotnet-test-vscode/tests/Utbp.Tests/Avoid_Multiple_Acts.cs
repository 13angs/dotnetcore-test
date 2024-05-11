using Utbp.Libs;

namespace Utbp.Tests;

public class Avoid_Multiple_Acts
{
    // bad
    [Fact]
    public void Add_EmptyEntries_ShouldBeTreatedAsZero1()
    {
        var stringCalculator = new StringCalculator();
        // Act
        var actual1 = stringCalculator.Add("");
        var actual2 = stringCalculator.Add(",");

        // Assert
        Assert.Equal(0, actual1);
        Assert.Equal(0, actual2);
    }

    // best
    [Theory]
    [InlineData("", 0)]
    [InlineData(",", 0)]
    public void Add_EmptyEntries_ShouldBeTreatedAsZero2(string input, int expected)
    {
        // Arrange
        var stringCalculator = new StringCalculator();

        // Act
        var actual = stringCalculator.Add(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}