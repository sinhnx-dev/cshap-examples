//Nullable type
int? i;
i = null;

Console.WriteLine(i);

//Nullable type
Nullable<int> i2;
i2 = null;
//print currency format
Console.WriteLine("{0:C}", i2 ?? 1121);
//print number format
Console.WriteLine("{0:###,###}", i2 ?? 11213241465465);

string[] msgs = { "msg1", "msg2", "msg3", "msg4", "msg5" };
foreach (string msg in msgs)
{
    Console.WriteLine(msg);
}

Console.Write("Input a string: ");
string? str = Console.ReadLine();
Console.WriteLine("str = " + str ?? "null");

Console.Write("Input an integer number: ");
str = Console.ReadLine();
int iNum;
if (int.TryParse(str, out iNum))
{
    Console.WriteLine($"i = {iNum}");
}
else
{
    Console.WriteLine($"\"{str}\" not is int number.");
}