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

    public static KeyValuePair<TKey, TValue> ToKeyValuePair<TKey, TValue>(this Tuple<TKey, TValue> tuple)
    {
        return new KeyValuePair<TKey, TValue>(tuple.Item1, tuple.Item2);
    }

    public static KeyValuePair<TKey, TValue> ToKeyValuePair<TKey, TValue>(this ValueTuple<TKey, TValue> tuple)
    {
        return new KeyValuePair<TKey, TValue>(tuple.Item1, tuple.Item2);
    }

    public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this Tuple<IEnumerable<TKey>, IEnumerable<TValue>> tuple)
        where TKey : notnull
    {
        var (count1, count2) = (tuple.Item1.Count(), tuple.Item2.Count());
        if (count1 != count2)
        {
            throw new ArgumentException("There must be an equal count of both keys and values");
        }

        return new Dictionary<TKey, TValue>(tuple.Item1.Zip(tuple.Item2).Select(x => x.ToKeyValuePair()));
    }

    public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this ValueTuple<IEnumerable<TKey>, IEnumerable<TValue>> tuple)
        where TKey : notnull
    {
        var (count1, count2) = (tuple.Item1.Count(), tuple.Item2.Count());
        if (count1 != count2)
        {
            throw new ArgumentException("There must be an equal count of both keys and values");
        }

        return new Dictionary<TKey, TValue>(tuple.Item1.Zip(tuple.Item2).Select(x => x.ToKeyValuePair()));
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