namespace CSharpUtilities;

public static partial class TupleExtension
{

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

}
