namespace CSharpUtilities;

/// <summary>
/// Implementation of F#-like pipe operator (|>).
/// </summary>
public static class PipeExtension
{

    #region Pipe

    public static TResult Pipe<TLast, TResult>(this TLast last, Func<TLast, TResult> func)
    {
        return func(last);
    }
    public static TResult Pipe<T1, TLast, TResult>(this TLast last, Func<T1, TLast, TResult> func, 
        T1 t1)
    {
        return func(t1, last);
    }
    public static TResult Pipe<T1, T2, TLast, TResult>(this TLast last, Func<T1, T2, TLast, TResult> func,
        T1 t1, T2 t2)
    {
        return func(t1, t2, last);
    }
    public static TResult Pipe<T1, T2, T3, TLast, TResult>(this TLast last, Func<T1, T2, T3, TLast, TResult> func, 
        T1 t1, T2 t2, T3 t3)
    {
        return func(t1, t2, t3, last);
    }
    public static TResult Pipe<T1, T2, T3, T4, TLast, TResult>(this TLast last, Func<T1, T2, T3, T4, TLast, TResult> func, 
        T1 t1, T2 t2, T3 t3, T4 t4)
    {
        return func(t1, t2, t3, t4, last);
    }
    public static TResult Pipe<T1, T2, T3, T4, T5, TLast, TResult>(this TLast last, Func<T1, T2, T3, T4, T5, TLast, TResult> func, 
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
    {
        return func(t1, t2, t3, t4, t5, last);
    }
    public static TResult Pipe<T1, T2, T3, T4, T5, T6, TLast, TResult>(this TLast last, Func<T1, T2, T3, T4, T5, T6, TLast, TResult> func, 
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
    {
        return func(t1, t2, t3, t4, t5, t6, last);
    }
    public static TResult Pipe<T1, T2, T3, T4, T5, T6, T7, TLast, TResult>(this TLast last, Func<T1, T2, T3, T4, T5, T6, T7, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, last);
    }
    public static TResult Pipe<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult>(this TLast last, Func<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, last);
    }
    public static TResult Pipe<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(this TLast last, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> func, 
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    }
    public static TResult Pipe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this TLast last, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    }
    public static TResult Pipe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this TLast last, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    }
    public static TResult Pipe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this TLast last, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    }
    public static TResult Pipe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this TLast last, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    }
    public static TResult Pipe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this TLast last, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    }
    public static TResult Pipe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this TLast last, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    }

    #endregion Pipe

}