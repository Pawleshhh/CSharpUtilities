namespace CSharpUtilities;

public static class DateTimeExtension
{

    #region Deconstructors

    public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day)
    {
        year = dateTime.Year;
        month = dateTime.Month;
        day = dateTime.Day;
    }

    public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hour, out int minute, out int second)
    {
        Deconstruct(dateTime, out year, out month, out day);
        hour = dateTime.Hour;
        minute = dateTime.Minute;
        second = dateTime.Second;
    }

    public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day, out int hour, out int minute, out int second, out int millisecond)
    {
        Deconstruct(dateTime, out year, out month, out day, out hour, out minute, out second);
        millisecond = dateTime.Millisecond;
    }

    #endregion

}
