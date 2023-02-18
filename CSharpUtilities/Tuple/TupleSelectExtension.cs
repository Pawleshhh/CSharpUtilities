namespace CSharpUtilities;

public static partial class TupleSelectExtension
{

    #region Select

    public static TResult Select<T1, T2, TResult>(
        this Tuple<T1, T2> tuple, Func<T1, T2, TResult> select)
    {
        return select(tuple.Item1, tuple.Item2);
    }

    public static TResult Select<T1, T2, TResult>(
        this ValueTuple<T1, T2> tuple, Func<T1, T2, TResult> select)
    {
        return select(tuple.Item1, tuple.Item2);
    }

    public static TResult Select<T1, T2, T3, TResult>(
        this Tuple<T1, T2, T3> tuple, Func<T1, T2, T3, TResult> select)
    {
        return select(tuple.Item1, tuple.Item2, tuple.Item3);
    }

    public static TResult Select<T1, T2, T3, TResult>(
        this ValueTuple<T1, T2, T3> tuple, Func<T1, T2, T3, TResult> select)
    {
        return select(tuple.Item1, tuple.Item2, tuple.Item3);
    }

    public static TResult Select<T1, T2, T3, T4, TResult>(
        this Tuple<T1, T2, T3, T4> tuple, Func<T1, T2, T3, T4, TResult> select)
    {
        return select(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
    }

    public static TResult Select<T1, T2, T3, T4, TResult>(
        this ValueTuple<T1, T2, T3, T4> tuple, Func<T1, T2, T3, T4, TResult> select)
    {
        return select(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
    }

    #endregion

}
