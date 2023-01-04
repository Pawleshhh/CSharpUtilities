using static CSharpUtilities.UtilsHelper;

namespace CSharpUtilities;

public static class StringExtension
{

    public static bool TryIndexOf(this string @string, string value, out int index)
        => TryGetIndexHelper(() => @string.IndexOf(value), out index);

}
