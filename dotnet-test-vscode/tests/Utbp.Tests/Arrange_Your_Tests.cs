using Utbp.Libs;
namespace Utbp.Tests;

public class Arrange_Your_Tests
{
    // Bad Practice
    [Fact]
    public void Add_EmptyString_ReturnsZero1()
    {
        // Arrange
        var stringCalculator = new StringCalculator();

        // Assert
        Assert.Equal(0, stringCalculator.Add(""));
    }

    // Good Practice
    [Fact]
    public void Add_EmptyString_ReturnsZero2()
    {
        // Arrange
        var stringCalculator = new StringCalculator();

        // Act
        var actual = stringCalculator.Add("");

        // Assert
        Assert.Equal(0, actual);
    }
}