using Md5Algorithms;

Console.Write("Input password: ");
string pass = Console.ReadLine() ?? "password";
string md5string = Md5Util.CreateMD5(pass);
Console.WriteLine("Password encrypted: {0}", md5string);