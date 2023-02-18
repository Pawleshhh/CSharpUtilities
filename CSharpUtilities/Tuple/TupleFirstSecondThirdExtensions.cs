namespace CSharpUtilities;

public static partial class TupleExtension
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
}
