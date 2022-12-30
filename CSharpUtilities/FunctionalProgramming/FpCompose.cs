namespace CSharpUtilities.FunctionalProgramming;

public static partial class Fp
{

    public static Func<A, C> Compose<A, B, C>(this Func<A, B> func1, Func<B, C> func2)
    {
        return p => func2(func1(p));
    }

    public static Func<A, C> Compose<T1, A, B, C>(this Func<T1, A, B> func1, T1 f1_t1, Func<T1, B, C> func2, T1 f2_t1)
    {
        return p => func2(f2_t1, func1(f1_t1, p));
    }

}
