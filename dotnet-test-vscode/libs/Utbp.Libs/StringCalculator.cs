namespace Utbp.Libs;
using System.Linq;

public class StringCalculator
{
    private const int MAXIMUM_RESULT = 1000;
    public int Add(string candidate)
    {
        // Add Single Number Returns Same Number
        if (candidate.Length == 1)
        {
            int.TryParse(candidate, out int result);
            return result;
        }
        // Add Empty String Returns Zero
        if (string.IsNullOrEmpty(candidate))
        {
            return 0;
        }
        // Add Multiple Numbers Returns Correct Results
        // Add Empty Entries Should Be Treated As Zero
        if(candidate.Length > 1 && candidate.Contains(","))
        {
            candidate = candidate.Trim();
            var nums = candidate.Split(",")
                .Select(x => int.Parse(x));
            return nums.Sum();
        }
        // Add Maximum Sum Result Throws OverflowException
        if (!string.IsNullOrEmpty(candidate))
        {
            int.TryParse(candidate, out int result);
            if (result > MAXIMUM_RESULT)
            {
                throw new OverflowException("Overflow exception");
            }
            return result;
        }
        throw new NotImplementedException("Not implemented.");
    }
}
