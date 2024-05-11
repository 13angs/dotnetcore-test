namespace Utbp.Libs;

public class Parser
{
    public string ParseLogLine(string input)
    {
        var sanitizedInput = TrimInput(input);
        return sanitizedInput;
    }

    private string TrimInput(string input)
    {
        return input.Trim();
    }
}