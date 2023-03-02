public class EnumDataType
{
    public static enum DayOfWeek
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Satursday
    };

    public static string GetDayOfWeek(DayOfWeek dow)
    {
        string dowString = "";
        switch (dow)
        {
            case DayOfWeek.Monday:
                dowString = "Monday";
                break;
            case DayOfWeek.Tuesday:
                dowString = "Tuesday";
                break;
            case DayOfWeek.Wednesday:
                dowString = "Wednesday";
                break;
            case DayOfWeek.Thursday:
                dowString = "Thursday";
                break;
            case DayOfWeek.Friday:
                dowString = "Friday";
                break;
            case DayOfWeek.Satursday:
                dowString = "Satursday";
                break;
            case DayOfWeek.Sunday:
                dowString = "Sunday";
                break;
            default:
                dowString = "Not day of week number.";
                break;
        }
        return dowString;
    }
}