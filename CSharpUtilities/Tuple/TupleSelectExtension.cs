namespace CSharpUtilities;

public static partial class TupleSelectExtension
{

    #region Select

    public static Tuple<TResult1, TResult2> Select<T1, T2, TResult1, TResult2>(
        this Tuple<T1, T2> tuple, Func<T1, T2, Tuple<TResult1, TResult2>> select)
    {
        return select(tuple.Item1, tuple.Item2);
    }

    public static ValueTuple<TResult1, TResult2> Select<T1, T2, TResult1, TResult2>(
        this ValueTuple<T1, T2> tuple, Func<T1, T2, ValueTuple<TResult1, TResult2>> select)
    {
        return select(tuple.Item1, tuple.Item2);
    }

    public static Tuple<TResult1, TResult2, TResult3> Select<T1, T2, T3, TResult1, TResult2, TResult3>(
        this Tuple<T1, T2, T3> tuple, Func<T1, T2, T3, Tuple<TResult1, TResult2, TResult3>> select)
    {
        return select(tuple.Item1, tuple.Item2, tuple.Item3);
    }

    public static ValueTuple<TResult1, TResult2, TResult3> Select<T1, T2, T3, TResult1, TResult2, TResult3>(
        this ValueTuple<T1, T2, T3> tuple, Func<T1, T2, T3, ValueTuple<TResult1, TResult2, TResult3>> select)
    {
        return select(tuple.Item1, tuple.Item2, tuple.Item3);
    }

    public static Tuple<TResult1, TResult2, TResult3, TResult4> Select<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4>(
        this Tuple<T1, T2, T3, T4> tuple, Func<T1, T2, T3, T4, Tuple<TResult1, TResult2, TResult3, TResult4>> select)
    {
        return select(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
    }

    public static ValueTuple<TResult1, TResult2, TResult3, TResult4> Select<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4>(
        this ValueTuple<T1, T2, T3, T4> tuple, Func<T1, T2, T3, T4, ValueTuple<TResult1, TResult2, TResult3, TResult4>> select)
    {
        return select(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
    }

    #endregion

}
