namespace CSharpUtilities;

public static partial class TupleExtension
{

    #region Concat2

    public static Tuple<T1, T2> Concat<T1, T2>(this Tuple<T1> tupleA, Tuple<T2> tupleB)
    {
        return new Tuple<T1, T2>(tupleA.Item1, tupleB.Item1);
    }

    public static ValueTuple<T1, T2> Concat<T1, T2>(this ValueTuple<T1> tupleA, ValueTuple<T2> tupleB)
    {
        return new ValueTuple<T1, T2>(tupleA.Item1, tupleB.Item1);
    }

    #endregion

    #region Concat3

    public static Tuple<T1, T2, T3> Concat<T1, T2, T3>(this Tuple<T1, T2> tupleA, Tuple<T3> tupleB)
    {
        return new Tuple<T1, T2, T3>(tupleA.Item1, tupleA.Item2, tupleB.Item1);
    }

    public static Tuple<T1, T2, T3> Concat<T1, T2, T3>(this Tuple<T1> tupleA, Tuple<T2, T3> tupleB)
    {
        return new Tuple<T1, T2, T3>(tupleA.Item1, tupleB.Item1, tupleB.Item2);
    }

    public static ValueTuple<T1, T2, T3> Concat<T1, T2, T3>(this ValueTuple<T1, T2> tupleA, ValueTuple<T3> tupleB)
    {
        return new ValueTuple<T1, T2, T3>(tupleA.Item1, tupleA.Item2, tupleB.Item1);
    }

    public static ValueTuple<T1, T2, T3> Concat<T1, T2, T3>(this ValueTuple<T1> tupleA, ValueTuple<T2, T3> tupleB)
    {
        return new ValueTuple<T1, T2, T3>(tupleA.Item1, tupleB.Item1, tupleB.Item2);
    }

    #endregion

    #region Concat4

    public static Tuple<T1, T2, T3, T4> Concat<T1, T2, T3, T4>(this Tuple<T1, T2> tupleA, Tuple<T3, T4> tupleB)
    {
        return new Tuple<T1, T2, T3, T4>(tupleA.Item1, tupleA.Item2, tupleB.Item1, tupleB.Item2);
    }

    public static Tuple<T1, T2, T3, T4> Concat<T1, T2, T3, T4>(this Tuple<T1, T2, T3> tupleA, Tuple<T4> tupleB)
    {
        return new Tuple<T1, T2, T3, T4>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleB.Item1);
    }

    public static Tuple<T1, T2, T3, T4> Concat<T1, T2, T3, T4>(this Tuple<T1> tupleA, Tuple<T2, T3, T4> tupleB)
    {
        return new Tuple<T1, T2, T3, T4>(tupleA.Item1, tupleB.Item1, tupleB.Item2, tupleB.Item3);
    }

    public static ValueTuple<T1, T2, T3, T4> Concat<T1, T2, T3, T4>(this ValueTuple<T1, T2> tupleA, ValueTuple<T3, T4> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4>(tupleA.Item1, tupleA.Item2, tupleB.Item1, tupleB.Item2);
    }

    public static ValueTuple<T1, T2, T3, T4> Concat<T1, T2, T3, T4>(this ValueTuple<T1, T2, T3> tupleA, ValueTuple<T4> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleB.Item1);
    }

    public static ValueTuple<T1, T2, T3, T4> Concat<T1, T2, T3, T4>(this ValueTuple<T1> tupleA, ValueTuple<T2, T3, T4> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4>(tupleA.Item1, tupleB.Item1, tupleB.Item2, tupleB.Item3);
    }

    #endregion

    #region Concat5

    public static Tuple<T1, T2, T3, T4, T5> Concat<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4> tupleA, Tuple<T5> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleB.Item1);
    }

    public static Tuple<T1, T2, T3, T4, T5> Concat<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3> tupleA, Tuple<T4, T5> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleB.Item1, tupleB.Item2);
    }

    public static Tuple<T1, T2, T3, T4, T5> Concat<T1, T2, T3, T4, T5>(this Tuple<T1, T2> tupleA, Tuple<T3, T4, T5> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5>(tupleA.Item1, tupleA.Item2, tupleB.Item1, tupleB.Item2, tupleB.Item3);
    }

    public static Tuple<T1, T2, T3, T4, T5> Concat<T1, T2, T3, T4, T5>(this Tuple<T1> tupleA, Tuple<T2, T3, T4, T5> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5>(tupleA.Item1, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4);
    }

    public static ValueTuple<T1, T2, T3, T4, T5> Concat<T1, T2, T3, T4, T5>(this ValueTuple<T1, T2, T3, T4> tupleA, ValueTuple<T5> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleB.Item1);
    }

    public static ValueTuple<T1, T2, T3, T4, T5> Concat<T1, T2, T3, T4, T5>(this ValueTuple<T1, T2, T3> tupleA, ValueTuple<T4, T5> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleB.Item1, tupleB.Item2);
    }

    public static ValueTuple<T1, T2, T3, T4, T5> Concat<T1, T2, T3, T4, T5>(this ValueTuple<T1, T2> tupleA, ValueTuple<T3, T4, T5> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5>(tupleA.Item1, tupleA.Item2, tupleB.Item1, tupleB.Item2, tupleB.Item3);
    }

    public static ValueTuple<T1, T2, T3, T4, T5> Concat<T1, T2, T3, T4, T5>(this ValueTuple<T1> tupleA, ValueTuple<T2, T3, T4, T5> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5>(tupleA.Item1, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4);
    }

    #endregion

    #region Concat6

    public static Tuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(
        this Tuple<T1> tupleA, Tuple<T2, T3, T4, T5, T6> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5, T6>(tupleA.Item1, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4, tupleB.Item5);
    }

    public static Tuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(
        this Tuple<T1, T2> tupleA, Tuple<T3, T4, T5, T6> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5, T6>(tupleA.Item1, tupleA.Item2, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4);
    }

    public static Tuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(
        this Tuple<T1, T2, T3> tupleA, Tuple<T4, T5, T6> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5, T6>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleB.Item1, tupleB.Item2, tupleB.Item3);
    }

    public static Tuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(
        this Tuple<T1, T2, T3, T4> tupleA, Tuple<T5, T6> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5, T6>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleB.Item1, tupleB.Item2);
    }

    public static Tuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(
        this Tuple<T1, T2, T3, T4, T5> tupleA, Tuple<T6> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5, T6>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleA.Item5, tupleB.Item1);
    }

    public static ValueTuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(
        this ValueTuple<T1> ValueTupleA, ValueTuple<T2, T3, T4, T5, T6> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5, T6>(ValueTupleA.Item1, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4, tupleB.Item5);
    }

    public static ValueTuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(
        this ValueTuple<T1, T2> ValueTupleA, ValueTuple<T3, T4, T5, T6> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5, T6>(ValueTupleA.Item1, ValueTupleA.Item2, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4);
    }

    public static ValueTuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(
        this ValueTuple<T1, T2, T3> ValueTupleA, ValueTuple<T4, T5, T6> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5, T6>(ValueTupleA.Item1, ValueTupleA.Item2, ValueTupleA.Item3, tupleB.Item1, tupleB.Item2, tupleB.Item3);
    }

    public static ValueTuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(
        this ValueTuple<T1, T2, T3, T4> ValueTupleA, ValueTuple<T5, T6> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5, T6>(ValueTupleA.Item1, ValueTupleA.Item2, ValueTupleA.Item3, ValueTupleA.Item4, tupleB.Item1, tupleB.Item2);
    }

    public static ValueTuple<T1, T2, T3, T4, T5, T6> Concat<T1, T2, T3, T4, T5, T6>(
        this ValueTuple<T1, T2, T3, T4, T5> ValueTupleA, ValueTuple<T6> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5, T6>(ValueTupleA.Item1, ValueTupleA.Item2, ValueTupleA.Item3, ValueTupleA.Item4, ValueTupleA.Item5, tupleB.Item1);
    }

    #endregion

    #region Concat7

    public static Tuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(
        this Tuple<T1> tupleA, Tuple<T2, T3, T4, T5, T6, T7> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4, tupleB.Item5, tupleB.Item6);
    }

    public static Tuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(
        this Tuple<T1, T2> tupleA, Tuple<T3, T4, T5, T6, T7> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4, tupleB.Item5);
    }

    public static Tuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(
        this Tuple<T1, T2, T3> tupleA, Tuple<T4, T5, T6, T7> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4);
    }

    public static Tuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(
        this Tuple<T1, T2, T3, T4> tupleA, Tuple<T5, T6, T7> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleB.Item1, tupleB.Item2, tupleB.Item3);
    }

    public static Tuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(
        this Tuple<T1, T2, T3, T4, T5> tupleA, Tuple<T6, T7> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleA.Item5, tupleB.Item1, tupleB.Item2);
    }

    public static Tuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(
        this Tuple<T1, T2, T3, T4, T5, T6> tupleA, Tuple<T7> tupleB)
    {
        return new Tuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleA.Item5, tupleA.Item6, tupleB.Item1);
    }

    public static ValueTuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(
        this ValueTuple<T1> tupleA, ValueTuple<T2, T3, T4, T5, T6, T7> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4, tupleB.Item5, tupleB.Item6);
    }

    public static ValueTuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(
        this ValueTuple<T1, T2> tupleA, ValueTuple<T3, T4, T5, T6, T7> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4, tupleB.Item5);
    }

    public static ValueTuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(
        this ValueTuple<T1, T2, T3> tupleA, ValueTuple<T4, T5, T6, T7> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleB.Item1, tupleB.Item2, tupleB.Item3, tupleB.Item4);
    }

    public static ValueTuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(
        this ValueTuple<T1, T2, T3, T4> tupleA, ValueTuple<T5, T6, T7> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleB.Item1, tupleB.Item2, tupleB.Item3);
    }

    public static ValueTuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(
        this ValueTuple<T1, T2, T3, T4, T5> tupleA, ValueTuple<T6, T7> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleA.Item5, tupleB.Item1, tupleB.Item2);
    }

    public static ValueTuple<T1, T2, T3, T4, T5, T6, T7> Concat<T1, T2, T3, T4, T5, T6, T7>(
        this ValueTuple<T1, T2, T3, T4, T5, T6> tupleA, ValueTuple<T7> tupleB)
    {
        return new ValueTuple<T1, T2, T3, T4, T5, T6, T7>(tupleA.Item1, tupleA.Item2, tupleA.Item3, tupleA.Item4, tupleA.Item5, tupleA.Item6, tupleB.Item1);
    }

    #endregion

}
