namespace CSharpUtilities.FunctionalProgramming;

public static partial class Fp
{

    #region Partly Action

    public static Action Partly<TLast>(this Action<TLast> action, TLast last)
    {
        return () => action(last);
    }
    public static Action<TLast> Partly<T1, TLast>(this Action<T1, TLast> action,
        T1 t1)
    {
        return last => action(t1, last);
    }
    public static Action<TLast> Partly<T1, T2, TLast>(this Action<T1, T2, TLast> action,
        T1 t1, T2 t2)
    {
        return last => action(t1, t2, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, TLast>(this Action<T1, T2, T3, TLast> action,
        T1 t1, T2 t2, T3 t3)
    {
        return last => action(t1, t2, t3, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, T4, TLast>(this Action<T1, T2, T3, T4, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4)
    {
        return last => action(t1, t2, t3, t4, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, T4, T5, TLast>(this Action<T1, T2, T3, T4, T5, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
    {
        return last => action(t1, t2, t3, t4, t5, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, T4, T5, T6, TLast>(this Action<T1, T2, T3, T4, T5, T6, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
    {
        return last => action(t1, t2, t3, t4, t5, t6, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, T4, T5, T6, T7, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
    {
        return last => action(t1, t2, t3, t4, t5, t6, t7, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, T4, T5, T6, T7, T8, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
    {
        return last => action(t1, t2, t3, t4, t5, t6, t7, t8, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
    {
        return last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
    {
        return last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
    {
        return last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
    {
        return last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
    {
        return last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
    {
        return last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    }
    public static Action<TLast> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
    {
        return last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    }

    #endregion Partly Action

    #region Partly Func

    public static Func<TResult> Partly<TLast, TResult>(this Func<TLast, TResult> func, TLast last)
    {
        return () => func(last);
    }
    public static Func<TLast, TResult> Partly<T1, TLast, TResult>(this Func<T1, TLast, TResult> func,
        T1 t1)
    {
        return last => func(t1, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, TLast, TResult>(this Func<T1, T2, TLast, TResult> func,
        T1 t1, T2 t2)
    {
        return last => func(t1, t2, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, TLast, TResult>(this Func<T1, T2, T3, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3)
    {
        return last => func(t1, t2, t3, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, T4, TLast, TResult>(this Func<T1, T2, T3, T4, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4)
    {
        return last => func(t1, t2, t3, t4, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, T4, T5, TLast, TResult>(this Func<T1, T2, T3, T4, T5, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
    {
        return last => func(t1, t2, t3, t4, t5, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, T4, T5, T6, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
    {
        return last => func(t1, t2, t3, t4, t5, t6, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, T4, T5, T6, T7, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
    {
        return last => func(t1, t2, t3, t4, t5, t6, t7, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
    {
        return last => func(t1, t2, t3, t4, t5, t6, t7, t8, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
    {
        return last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
    {
        return last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
    {
        return last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
    {
        return last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
    {
        return last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
    {
        return last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    }
    public static Func<TLast, TResult> Partly<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
    {
        return last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    }

    #endregion Partly

}
