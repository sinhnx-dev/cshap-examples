using System.Text.RegularExpressions;

Console.Write("Input Email: ");
string e = Console.ReadLine() ?? "";
string pattern = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";
if (Regex.IsMatch(e, pattern, RegexOptions.IgnoreCase))
{
    Console.WriteLine($"'{e}' is an email address.");
}
else
{
    Console.WriteLine($"'{e}' is not an email address.");
}
