using CSharpUtilities.FunctionalProgramming;

namespace CSharpUtilities;

public static class StringExtension
{

    public static bool TryIndexOf(this string @string, string value, out int index)
    {
        index = @string.IndexOf(value);
        return index >= 0;
    }

}
