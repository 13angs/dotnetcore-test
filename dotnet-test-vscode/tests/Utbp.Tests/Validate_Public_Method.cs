using Utbp.Libs;

namespace Utbp.Tests;

public class Validate_Public_Method
{
    public void ParseLogLine_StartsAndEndsWithSpace_ReturnsTrimmedResult()
    {
        var parser = new Parser();

        var result = parser.ParseLogLine(" a ");

        Assert.Equal("a", result);
    }
}