namespace CSharpUtilities.FunctionalProgramming;

public static partial class Fp
{

    public static Func<T> SetupBuild<T>(this T next, Func<T, T> build)
    {
        return () => build(next);
    }

    public static Func<TTo> SetupBuild<TFrom, TTo>(this TFrom next, Func<TFrom, TTo> build)
    {
        return () => build(next);
    }

}
