using System.Runtime.CompilerServices;

namespace CSharpUtilities;

public static class TupleExtension
{

    #region First

    public static T1? First<T1, T2>(this Tuple<T1, T2> tuple)
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2>(this ValueTuple<T1, T2> tuple)
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2, T3>(this Tuple<T1, T2, T3> tuple)
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2, T3>(this ValueTuple<T1, T2, T3> tuple)
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> tuple)
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2, T3, T4>(this ValueTuple<T1, T2, T3, T4> tuple)
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> tuple)
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2, T3, T4, T5>(this ValueTuple<T1, T2, T3, T4, T5> tuple)
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> tuple)
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2, T3, T4, T5, T6>(this ValueTuple<T1, T2, T3, T4, T5, T6> tuple)
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> tuple)
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2, T3, T4, T5, T6, T7>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7> tuple)
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2, T3, T4, T5, T6, T7, TRest>(this Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple) where TRest : notnull
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    public static T1? First<T1, T2, T3, T4, T5, T6, T7, TRest>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple) where TRest : struct
    {
        return GetTupleAt<T1>(tuple, 0);
    }

    #endregion

    #region Second

    public static T2? Second<T1, T2>(this Tuple<T1, T2> tuple)
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2>(this ValueTuple<T1, T2> tuple)
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2, T3>(this Tuple<T1, T2, T3> tuple)
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2, T3>(this ValueTuple<T1, T2, T3> tuple)
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> tuple)
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2, T3, T4>(this ValueTuple<T1, T2, T3, T4> tuple)
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> tuple)
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2, T3, T4, T5>(this ValueTuple<T1, T2, T3, T4, T5> tuple)
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> tuple)
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2, T3, T4, T5, T6>(this ValueTuple<T1, T2, T3, T4, T5, T6> tuple)
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> tuple)
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2, T3, T4, T5, T6, T7>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7> tuple)
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2, T3, T4, T5, T6, T7, TRest>(this Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple) where TRest : notnull
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    public static T2? Second<T1, T2, T3, T4, T5, T6, T7, TRest>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple) where TRest : struct
    {
        return GetTupleAt<T2>(tuple, 1);
    }

    #endregion

    #region Third

    public static T3? Third<T1, T2, T3>(this Tuple<T1, T2, T3> tuple)
    {
        return GetTupleAt<T3>(tuple, 2);
    }

    public static T3? Third<T1, T2, T3>(this ValueTuple<T1, T2, T3> tuple)
    {
        return GetTupleAt<T3>(tuple, 2);
    }

    public static T3? Third<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> tuple)
    {
        return GetTupleAt<T3>(tuple, 2);
    }

    public static T3? Third<T1, T2, T3, T4>(this ValueTuple<T1, T2, T3, T4> tuple)
    {
        return GetTupleAt<T3>(tuple, 2);
    }

    public static T3? Third<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> tuple)
    {
        return GetTupleAt<T3>(tuple, 2);
    }

    public static T3? Third<T1, T2, T3, T4, T5>(this ValueTuple<T1, T2, T3, T4, T5> tuple)
    {
        return GetTupleAt<T3>(tuple, 2);
    }

    public static T3? Third<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> tuple)
    {
        return GetTupleAt<T3>(tuple, 2);
    }

    public static T3? Third<T1, T2, T3, T4, T5, T6>(this ValueTuple<T1, T2, T3, T4, T5, T6> tuple)
    {
        return GetTupleAt<T3>(tuple, 2);
    }

    public static T3? Third<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> tuple)
    {
        return GetTupleAt<T3>(tuple, 2);
    }

    public static T3? Third<T1, T2, T3, T4, T5, T6, T7>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7> tuple)
    {
        return GetTupleAt<T3>(tuple, 2);
    }

    public static T3? Third<T1, T2, T3, T4, T5, T6, T7, TRest>(this Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple) where TRest : notnull
    {
        return GetTupleAt<T3>(tuple, 2);
    }

    public static T3? Third<T1, T2, T3, T4, T5, T6, T7, TRest>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple) where TRest : struct
    {
        return GetTupleAt<T3>(tuple, 2);
    }

    #endregion

    #region Last

    public static T2? Last<T1, T2>(this Tuple<T1, T2> tuple)
    {
        return tuple.SkipLast(0);
    }

    public static T2? Last<T1, T2>(this ValueTuple<T1, T2> tuple)
    {
        return tuple.SkipLast(0);
    }

    public static T3? Last<T1, T2, T3>(this Tuple<T1, T2, T3> tuple)
    {
        return tuple.SkipLast(0);
    }

    public static T3? Last<T1, T2, T3>(this ValueTuple<T1, T2, T3> tuple)
    {
        return tuple.SkipLast(0);
    }

    public static T4? Last<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> tuple)
    {
        return tuple.SkipLast(0);
    }

    public static T4? Last<T1, T2, T3, T4>(this ValueTuple<T1, T2, T3, T4> tuple)
    {
        return tuple.SkipLast(0);
    }

    public static T5? Last<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> tuple)
    {
        return tuple.SkipLast(0);
    }

    public static T5? Last<T1, T2, T3, T4, T5>(this ValueTuple<T1, T2, T3, T4, T5> tuple)
    {
        return tuple.SkipLast(0);
    }

    public static T6? Last<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> tuple)
    {
        return tuple.SkipLast(0);
    }

    public static T6? Last<T1, T2, T3, T4, T5, T6>(this ValueTuple<T1, T2, T3, T4, T5, T6> tuple)
    {
        return tuple.SkipLast(0);
    }

    public static T7? Last<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> tuple)
    {
        return tuple.SkipLast(0);
    }

    public static T7? Last<T1, T2, T3, T4, T5, T6, T7>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7> tuple)
    {
        return tuple.SkipLast(0);
    }

    public static TRest? Last<T1, T2, T3, T4, T5, T6, T7, TRest>(this Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple) where TRest : notnull
    {
        return tuple.SkipLast(0);
    }

    public static TRest? Last<T1, T2, T3, T4, T5, T6, T7, TRest>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple) where TRest : struct
    {
        return tuple.SkipLast(0);
    }

    #endregion

    #region SkipLast

    public static T2? SkipLast<T1, T2>(this Tuple<T1, T2> tuple, int count)
    {
        return GetTupleAt<T2>(tuple, tuple.GetLength() - (count + 1));
    }

    public static T2? SkipLast<T1, T2>(this ValueTuple<T1, T2> tuple, int count)
    {
        return GetTupleAt<T2>(tuple, tuple.GetLength() - (count + 1));
    }

    public static T3? SkipLast<T1, T2, T3>(this Tuple<T1, T2, T3> tuple, int count)
    {
        return GetTupleAt<T3>(tuple, tuple.GetLength() - (count + 1));
    }

    public static T3? SkipLast<T1, T2, T3>(this ValueTuple<T1, T2, T3> tuple, int count)
    {
        return GetTupleAt<T3>(tuple, tuple.GetLength() - (count + 1));
    }

    public static T4? SkipLast<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> tuple, int count)
    {
        return GetTupleAt<T4>(tuple, tuple.GetLength() - (count + 1));
    }

    public static T4? SkipLast<T1, T2, T3, T4>(this ValueTuple<T1, T2, T3, T4> tuple, int count)
    {
        return GetTupleAt<T4>(tuple, tuple.GetLength() - (count + 1));
    }

    public static T5? SkipLast<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> tuple, int count)
    {
        return GetTupleAt<T5>(tuple, tuple.GetLength() - (count + 1));
    }

    public static T5? SkipLast<T1, T2, T3, T4, T5>(this ValueTuple<T1, T2, T3, T4, T5> tuple, int count)
    {
        return GetTupleAt<T5>(tuple, tuple.GetLength() - (count + 1));
    }

    public static T6? SkipLast<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> tuple, int count)
    {
        return GetTupleAt<T6>(tuple, tuple.GetLength() - (count + 1));
    }

    public static T6? SkipLast<T1, T2, T3, T4, T5, T6>(this ValueTuple<T1, T2, T3, T4, T5, T6> tuple, int count)
    {
        return GetTupleAt<T6>(tuple, tuple.GetLength() - (count + 1));
    }

    public static T7? SkipLast<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> tuple, int count)
    {
        return GetTupleAt<T7>(tuple, tuple.GetLength() - (count + 1));
    }

    public static T7? SkipLast<T1, T2, T3, T4, T5, T6, T7>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7> tuple, int count)
    {
        return GetTupleAt<T7>(tuple, tuple.GetLength() - (count + 1));
    }

    public static TRest? SkipLast<T1, T2, T3, T4, T5, T6, T7, TRest>(this Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple, int count) where TRest : notnull
    {
        return GetTupleAt<TRest>(tuple, tuple.GetLength() - (count + 1));
    }

    public static TRest? SkipLast<T1, T2, T3, T4, T5, T6, T7, TRest>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple, int count) where TRest : struct
    {
        return GetTupleAt<TRest>(tuple, tuple.GetLength() - (count + 1));
    }

    #endregion

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
        return select(tuple.Item1, tuple.Item2,  tuple.Item3);
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