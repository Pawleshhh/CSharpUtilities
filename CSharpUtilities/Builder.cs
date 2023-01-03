namespace CSharpUtilities;

public static class Builder
{

    public static T Next<T>(this T next, Action<T> action)
    {
        action(next);
        return next;
    }

    public static T Next<T, TResult>(this T next, Func<T, TResult> func, out TResult result)
    {
        result = func(next);
        return next;
    }

}
