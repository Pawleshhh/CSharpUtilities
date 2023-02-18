using System.Runtime.CompilerServices;

namespace CSharpUtilities;

public static partial class TupleExtension
{

    #region Other

    public static IEnumerable<object?> AsEnumerable(this ITuple tuple)
    {
        return Enumerable.Range(0, tuple.Length).Select(i => tuple[i]);
    }

    public static IEnumerable<T> AsEnumerable<T>(this ITuple tuple)
    {
        return tuple.AsEnumerable().Cast<T>();
    }

    public static object? At(this ITuple tuple, int index)
    {
        return tuple[index];
    }

    public static T? At<T>(this ITuple tuple, int index)
    {
        return (T?)tuple.At(index);
    }

    public static int GetLength(this ITuple tuple)
    {
        return tuple.Length;
    }

    #endregion

    #region Helpers

    private static T? GetTupleAt<T>(ITuple tuple, int index)
        => (T?)tuple[index];

    #endregion

}