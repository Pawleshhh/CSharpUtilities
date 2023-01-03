namespace CSharpUtilities;

public static class ArrayExtension
{

    public static int IndexOf<T>(this T[] array, T value)
        => Array.IndexOf(array, value);

    public static void Clear<T>(this T[] array)
        => Array.Clear(array);

    public static void Clear<T>(this T[] array, int index, int length)
       => Array.Clear(array, index, length);

}
