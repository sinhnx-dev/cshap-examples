//Enum Type demo
System.Console.Write("Input number day of week: ");
int dow;
if (int.TryParse(Console.ReadLine() ?? "", out dow))
{
    string dowStr = EnumDataType.GetDayOfWeek((EnumDataType.DayOfWeek)dow);
    Console.WriteLine(dowStr);
}
else
{
    Console.WriteLine("Input value is not a integer number.");
}